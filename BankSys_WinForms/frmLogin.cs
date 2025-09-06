using BankBusinessLayer;
using BankSys_WinForms.Properties;
using System;
using System.Drawing;
using System.Web.UI;
using System.Windows.Forms;

namespace BankSys_WinForms
{
    public partial class frmLogin : Form
    {

        //var Move form without border
        int ve;
        int x;
        int y;
        public clsUser LoggedUser { get; set; }
        public int FalseCount = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();


            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                 lblError.Text = "⚠️ الرجاء إدخال اسم المستخدم وكلمة المرور";
                return;
            }

            clsUser user = clsUser.Find(userName);

            if (user != null && user.Password == password)
            {
                // نجاح تسجيل الدخول
                LoggedUser = user;
                clsLoginRegister.AddNewLoginRegister(user.UserID, true, Environment.MachineName);

                clsGlobal.CurrentUser = user;
                this.DialogResult = DialogResult.OK;
                frmMain main = new frmMain();
                main.ShowDialog();
                this.Close();
                this.Hide();
            }
            else
            {
                // فشل تسجيل الدخول
                if (user != null)
                    clsLoginRegister.AddNewLoginRegister(user.UserID, false, Environment.MachineName);

                lblError.Visible = true;
                lblTrys.Visible = true;
                FalseCount++;
                lblError.Text = " اسم المستخدم أو كلمة المرور غير صحيحة \n اضغط على \" اذا لم تتذكر كلمة المرور \"اضغط على نسيت كلمة المرور";
                lblTrys.Text = "لقد استخدمت عدد [ " + FalseCount + " ] محاولة / محاولات من 3 محاولات";
                txtUserName.Text = string.Empty;
                txtPassword.Text = string.Empty;
                lblUserName.Visible = true;
                lblPassword.Visible = true;
                txtUserName.Focus();

                if (FalseCount == 3)
                {
                     MessageBox.Show(
                         "🚫 لقد استخدمت كافة المحاولات للدخول.\n\n🔒 سوف يُغلق النظام... وداعاً 👋 نراك لاحقاً.",
                         "إغلاق النظام",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Stop
                     );
                    this.Close();
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void plTop_MouseDown(object sender, MouseEventArgs e)
        {
            ve = 1;
            x = e.X;
            y = e.Y;
        }

        private void plTop_MouseUp(object sender, MouseEventArgs e)
        {
            ve = 0;
        }

        private void plTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (ve == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtPassword.Tag.ToString() == "Hide")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0';
                pictureBox3.Image = Resources.EyeIcon;
                txtPassword.Tag = "Show";
            }
            else if (txtPassword.Tag.ToString() == "Show")
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.PasswordChar = '●';
                pictureBox3.Image = Resources.EyeCrossedIcon;
                txtPassword.Tag = "Hide";

            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            lblUserName.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPassword.Visible = false;
        }

    }
}