using BankBusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BankSys_WinForms.Users
{
    public partial class frmAddEditUser : Form
    {

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _UserID;
        clsUser _User;

        public frmAddEditUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;

            if (_UserID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }


        private void _LoadData()
        {


            if (_Mode == enMode.AddNew)
            {
                this.Text = "شاشة اضافة عميل جديد";
                _User = new clsUser();
                return;
            }

            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show("هذا النموذج سيتم إغلاقه لأنه لا يوجد مستخدم بالرقم: " + _UserID);
                this.Close();
                return;
            }

            this.Text = "شاشة تعديل بيانات المستخدم";
            lblUserID.Text = _UserID.ToString();
            txtFirstName.Text = _User.FirstName;
            txtLastName.Text = _User.LastName;
            txtEmail.Text = _User.Email;
            mtxtPhone.Text = _User.Phone;
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;




            if (_User.Image != "")
            {
                picUser.Load(_User.Image);
            }

            btnRemoveImage.Visible = (_User.Image != "");

            _LoadPermissions();

        }

        private void _LoadPermissions()
        {
            // تفعيل/تعطيل عناصر التحكم بناءً على الصلاحيات
            cbClientsManaga.Checked = _User.CheckAccessPermission(clsUser.enPermissions.pClientsManagement);
            cbAccountsManaga.Checked = _User.CheckAccessPermission(clsUser.enPermissions.pAccountsManagement);
            cbTransctionsManaga.Checked = _User.CheckAccessPermission(clsUser.enPermissions.pTranactionsManagement);
            cbUsersManaga.Checked = _User.CheckAccessPermission(clsUser.enPermissions.pUsersManagement);
            cbCurrencyManaga.Checked = _User.CheckAccessPermission(clsUser.enPermissions.pCurrencyManagement);
            cbLoginRegister.Checked = _User.CheckAccessPermission(clsUser.enPermissions.pLoginRegister);

            // التحقق إذا كان لديه جميع الصلاحيات
            if (_User.Permissions == (int)clsUser.enPermissions.eAll)
            {
                rbYes.Checked = true;
                rbNo.Checked = false;
            }
            else
            {
                rbYes.Checked = false;
                rbNo.Checked = true;
            }
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _LoadData();

        }

        private void btnSetImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);
                picUser.Load(selectedFilePath);
                btnRemoveImage.Visible = true;

            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            picUser.ImageLocation = null;
            btnRemoveImage.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateData())
                return;

            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;
            _User.FirstName = txtFirstName.Text;
            _User.LastName = txtLastName.Text;
            _User.Email = txtEmail.Text;
            _User.Phone = mtxtPhone.Text;
            _User.Permissions = _GetPermissionsValue();


            if (picUser.ImageLocation != null)
                _User.Image = picUser.ImageLocation;
            else
                _User.Image = "";


            if (_User.Save())
            { 
                MessageBox.Show("تم حفظ البيانات بنجاح ✅", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                _UserID = _User.UserID;
                lblUserID.Text = _UserID.ToString();
            }
            else
                MessageBox.Show("خطأ: لم يتم حفظ البيانات !!! ❎", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //#######################################################################################


        private bool _ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("يرجى إدخال اسم المستخدم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("يرجى إدخال كلمة المرور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("يرجى إدخال الاسم الأول", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("يرجى إدخال الاسم الأخير", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(mtxtPhone.Text))
            {
                MessageBox.Show("يرجى إدخال رقم الهاتف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtPhone.Focus();
                return false;
            }

            // التحقق من البريد الإلكتروني إذا تم إدخاله
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("يرجى إدخال بريد إلكتروني صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            // التحقق من عدم وجود اسم مستخدم مكرر في حالة الإضافة
            if (_Mode == enMode.AddNew && clsUser.IsUserExist(txtUserName.Text.Trim()))
            {
                MessageBox.Show("اسم المستخدم موجود مسبقاً، يرجى اختيار اسم آخر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private int _GetPermissionsValue()
        {
            int permissions = 0;

            if (rbYes.Checked)
                return (int)clsUser.enPermissions.eAll;

            if (cbClientsManaga.Checked)
                permissions += (int)clsUser.enPermissions.pClientsManagement;

            if (cbAccountsManaga.Checked)
                permissions += (int)clsUser.enPermissions.pAccountsManagement;

            if (cbTransctionsManaga.Checked)
                permissions += (int)clsUser.enPermissions.pTranactionsManagement;

            if (cbUsersManaga.Checked)
                permissions += (int)clsUser.enPermissions.pUsersManagement;

            if (cbCurrencyManaga.Checked)
                permissions += (int)clsUser.enPermissions.pCurrencyManagement;

            if (cbLoginRegister.Checked)
                permissions += (int)clsUser.enPermissions.pLoginRegister;

            return permissions;
        }
        //#######################################################################################

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYes.Checked)
            {
                foreach (Control control in gbPermissions.Controls)
                {
                    if (control is CheckBox checkBox)
                    {
                        checkBox.Checked = true;
                        checkBox.Enabled = false;
                    }
                }
            }
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNo.Checked)
            {
                foreach (Control control in gbPermissions.Controls)
                {
                    if (control is CheckBox checkBox)
                    {
                        checkBox.Enabled = true;
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "اسم المستخدم مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtUserName, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "كلمة المرور مطلوبة");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPassword, "");
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "الاسم الأول مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "الاسم الأخير مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtLastName, "");
            }
        }

        private void mtxtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtPhone.Text) || mtxtPhone.Text.Contains(" "))
            {
                errorProvider1.SetError(mtxtPhone, "رقم الهاتف مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(mtxtPhone, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "بريد إلكتروني غير صحيح");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
        }
    
    }
}
