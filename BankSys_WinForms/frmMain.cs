using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankBusinessLayer;
using BankSys_WinForms.Accounts;
using BankSys_WinForms.Currency;
using BankSys_WinForms.LoginRegister;
using BankSys_WinForms.Transaction;
using BankSys_WinForms.Users;
using Guna;
using Guna.UI2.WinForms;

namespace BankSys_WinForms
{
       

    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClientsScreen_Click(object sender, EventArgs e)
        {
            if (!clsScreen.CheckAccessRights(clsUser.enPermissions.pClientsManagement))
            {
                return;
            }
            plMain.Visible = false;
            frmClient frmCli = new frmClient();
            frmCli.MdiParent = this;
            frmCli.Show();
        }

        private void btnMainScreen_Click(object sender, EventArgs e)
        {
            //frmClient frmCli = new frmClient(-1);
            //frmCli.Close();
            plMain.Visible = true;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SetGreetingMessage()
        {
            DateTime now = DateTime.Now;

            if (now.DayOfWeek == DayOfWeek.Friday)
            {
                lblMessage.Text = "جمعتك مباركة";
                return;
            }

            int hour = now.Hour;

            if (hour >= 1 && hour < 12)
            {
                lblMessage.Text = "صباح الخير";
            }
            else if (hour >= 12 && hour < 23)
            {
                lblMessage.Text = "مساء الخير";
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblClientsCount.Text = clsClient.GetAllClients().Rows.Count.ToString();
            lblAccounts.Text = clsAccount.GetAllAccounts().Rows.Count.ToString();
            lblTransacitonCount.Text = clsTransaction.GetAllTransactions().Rows.Count.ToString();
            lblUsersCount.Text = clsUser.GetAllUsers().Rows.Count.ToString();
            lblLoginRegCount.Text = clsLoginRegister.GetAllLoginRegisters().Rows.Count.ToString();

            SetGreetingMessage();

            lblUserName.Text = clsGlobal.CurrentUser.FirstName;

        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    lblDateTime.Text = DateTime.Now.ToString("dd-MM-yyyy _ hh:mm:ss");
        //}

        private void btnAccountsScreen_Click(object sender, EventArgs e)
        {
            if (!clsScreen.CheckAccessRights(clsUser.enPermissions.pAccountsManagement))
            {
                return;
            }
            plMain.Visible = false;
            frmAccount frmAcc = new frmAccount();
            frmAcc.MdiParent = this;
            frmAcc.Show();
        }

        private void btnTransactionsScreen_Click(object sender, EventArgs e)
        {
            if (!clsScreen.CheckAccessRights(clsUser.enPermissions.pTranactionsManagement))
            {
                return;
            }
            plMain.Visible = false;
            frmTransaction frmTran = new frmTransaction();
            frmTran.MdiParent = this;
            frmTran.Show();
        }

        private void btnUsersScreen_Click(object sender, EventArgs e)
        {
            if (!clsScreen.CheckAccessRights(clsUser.enPermissions.pUsersManagement))
            {
                return;
            }
            plMain.Visible = false;
            frmUsers frmUser = new frmUsers();
            frmUser.MdiParent = this;
            frmUser.Show();
        }

        private void btnCurrencyScreen_Click(object sender, EventArgs e)
        {
            if (!clsScreen.CheckAccessRights(clsUser.enPermissions.pCurrencyManagement))
            {
                return;
            }
            plMain.Visible = false;
            frmCurrency frmCurren = new frmCurrency();
            frmCurren.MdiParent = this;
            frmCurren.Show();
        }

        private void btnLoginRegisterScreen_Click(object sender, EventArgs e)
        {
            if (!clsScreen.CheckAccessRights(clsUser.enPermissions.pLoginRegister))
            {
                return;
            }
            plMain.Visible = false;
            frmLoginRegister frmLoginReg = new frmLoginRegister();
            frmLoginReg.MdiParent = this;
            frmLoginReg.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
