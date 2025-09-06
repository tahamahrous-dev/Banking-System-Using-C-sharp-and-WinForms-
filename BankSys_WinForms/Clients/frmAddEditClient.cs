using BankBusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BankSys_WinForms.Clients
{
    public partial class frmAddEditClient : Form
    {

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _ClientID;
        clsClient _Client;

        private bool _isLoadingCombos = false;

        

        public frmAddEditClient(int ClientID)
        {
            InitializeComponent();

            _ClientID = ClientID;
            _FillGenderInComboBox();

            if (_ClientID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;


            cmbGender.Validating += cmbGender_Validating;
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtEmail.Text, pattern))
            {
                e.Cancel = true;
                MessageBox.Show("الرجاء إدخال بريد إلكتروني صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadCustomerLocationForEdit(int customerAlmohafezaID, int customerAlmadireyahID)
        {
            _isLoadingCombos = true;
            try
            {
                // 1) Fill governorates
                _FillAlmohafezasInComboBox();

                // 2) Select the customer’s governorate
                cmbAlmuhafazah.SelectedValue = customerAlmohafezaID;

                // 3) Now that we know the governorate, fill its directorates
                _FillAlmadireyahsInComboBox(customerAlmohafezaID);

                // 4) Select the customer’s directorate
                cmbAlmudiriyah.SelectedValue = customerAlmadireyahID;
            }
            finally
            {
                _isLoadingCombos = false;
            }
        }

        private void _FillGenderInComboBox()
        {
            cmbGender.DataSource = clsClient.GetGenders();
            cmbGender.DisplayMember = "Gender"; 
            cmbGender.ValueMember = "Gender";
        }

        private void _FillAlmohafezasInComboBox()
        {
            cmbAlmuhafazah.DataSource = clsClient.GetAlmohafezas();
            cmbAlmuhafazah.DisplayMember = "AlmohafezaName";
            cmbAlmuhafazah.ValueMember = "AlmohafezaID";
        }

        private void _FillAlmadireyahsInComboBox(int AlmohafezaID)
        {
            cmbAlmudiriyah.DataSource = clsClient.CostomAlmadireyahs(AlmohafezaID);
            cmbAlmudiriyah.DisplayMember = "AlmadireyahName";
            cmbAlmudiriyah.ValueMember = "AlmadireyahID";
        }


        private void _LoadData()
        {


            if (_Mode == enMode.AddNew)
            {
                this.Text = "شاشة اضافة عميل جديد";
                _Client = new clsClient();
                return;
            }

            _Client = clsClient.Find(_ClientID);

            if (_Client == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _ClientID);
                this.Close();

                return;
            }

            this.Text = "شاشة تعديل بيانات العميل";
            lblClientID.Text = _ClientID.ToString();
            txtFirstName.Text = _Client.FirstName;
            txtMidName.Text = _Client.MidName;
            txtLastName.Text = _Client.LastName;
            dtpDateOfBirth.Value = _Client.DateOfBirth;
            cmbGender.Text = _Client.Gender;
            mtxtPersonalID.Text = _Client.Personal_ID_Number;
            txtEmail.Text = _Client.Email;
            mtxtPhone.Text = _Client.Phone;
            cmbAlmuhafazah.SelectedValue = _Client.Country;
            cmbAlmudiriyah.ValueMember = _Client.City.ToString();
            txtUserName.Text = _Client.UserName_OR_Phone.ToString();
            txtPassword.Text = _Client.Password;

            

            
            if (_Client.Image != "")
            {
                picClient.Load(_Client.Image);
            }

            btnImageDelete.Visible = (_Client.Image != "");

         

        }

        private void frmAdd_UpdateClient_Load(object sender, EventArgs e)
        {
            _LoadData();

            if (_Mode == enMode.Update)
            {
                int customerAlmohafezaID = _Client.Country;
                int customerAlmadireyahID = _Client.City;

                LoadCustomerLocationForEdit(customerAlmohafezaID, customerAlmadireyahID);
            }
            else
            {
                _FillAlmohafezasInComboBox();
            }
        }

        private void btnImageAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                picClient.Load(selectedFilePath);
            }
        }

        private void btnImageDelete_Click(object sender, EventArgs e)
        {
            picClient.ImageLocation = null;
            btnImageDelete.Visible = false;
        }

        private void brnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _Client.FirstName = txtFirstName.Text;
            _Client.MidName = txtMidName.Text;
            _Client.LastName = txtLastName.Text;
            _Client.DateOfBirth = dtpDateOfBirth.Value;
            _Client.Email = txtEmail.Text;
            _Client.Country = Convert.ToInt32(cmbAlmuhafazah.SelectedValue);
            _Client.City = Convert.ToInt32(cmbAlmudiriyah.SelectedValue);


            if (mtxtPersonalID.Text != null)
            _Client.Personal_ID_Number = mtxtPersonalID.Text;
            else
                _Client.Personal_ID_Number = "";


            if (mtxtPhone.Text != "")
                _Client.Phone = mtxtPhone.Text;
            else
                _Client.Phone = "";



            if (picClient.ImageLocation != null)
                _Client.Image = picClient.ImageLocation;
            else
                _Client.Image = "";

            if (_Client.Save())
                MessageBox.Show(" ✅ تم حفظ البيانات بنجاج", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (_Mode == enMode.AddNew)
            {
                clsAccount.CreateDefaultAccountsForClient(_Client.ClientID);
                MessageBox.Show("✅ تم إنشاء الحسابات الافتراضية للعميل حساب الريال اليمني والريال السعودي والدولار الامريكي", "",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(" !!! ❎ خطأ: لم يتم حفظ البيانات ");

            _Mode = enMode.Update;
            lblClientID.Text = _Client.ClientID.ToString();
            //this.Close();
        }

        private void cmbAlmuhafazah_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadingCombos) return;

            if (cmbAlmuhafazah.SelectedValue != null && cmbAlmuhafazah.SelectedValue is int)
            {
                int selectedAlmohafezaID = (int)cmbAlmuhafazah.SelectedValue;
                _FillAlmadireyahsInComboBox(selectedAlmohafezaID);
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "الاسم الاول مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txtMidName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMidName.Text))
            {
                errorProvider1.SetError(txtMidName, "الاسم الثاني مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtMidName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "اللقب مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtLastName, "");
            }
        }

        private void cmbGender_Validating(object sender, CancelEventArgs e)
        {
            if (cmbGender.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbGender, "يجب تحديد نوع العميل");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cmbGender, "");
            }
        }

        private void mtxtPersonalID_Validating(object sender, CancelEventArgs e)
        {
            string cleanText = mtxtPersonalID.Text.Replace("-", "").Replace("_", "").Trim();

            if (cleanText.Length != 11)
            {
                errorProvider1.SetError(mtxtPersonalID, "يجب ان يكون رقم البطاقة 11 رقم");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(mtxtPersonalID, "");
            }
        }

        private void mtxtPhone_Validating(object sender, CancelEventArgs e)
        {
            string cleanText = mtxtPhone.Text.Replace("-", "").Replace("_", "").Trim();

            if (cleanText.Length != 9)
            {
                errorProvider1.SetError(mtxtPhone, "يجب ان يكون رقم التلفون 9 ارقام");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(mtxtPhone, "");
            }
        }

        //private void cmbAlmuhafazah_Validating(object sender, CancelEventArgs e)
        //{
        //    if (cmbAlmuhafazah.SelectedIndex == 0)
        //    {
        //        errorProvider1.SetError(cmbAlmuhafazah, "يجب تحديد المحافظة");
        //        e.Cancel = true;
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(cmbAlmuhafazah, "");
        //    }
        //}

        //private void cmbAlmudiriyah_Validating(object sender, CancelEventArgs e)
        //{
        //    if (cmbAlmudiriyah.SelectedIndex == 0)
        //    {
        //        errorProvider1.SetError(cmbAlmudiriyah, "يجب تحديد المديرية");
        //        e.Cancel = true;
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(cmbAlmudiriyah, "");
        //    }
        //}
    }
}
