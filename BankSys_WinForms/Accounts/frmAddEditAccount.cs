using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSys_WinForms.Accounts
{
    public partial class frmAddEditAccount : Form
    {

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _AccountID;
        clsAccount _Account;

        public frmAddEditAccount(int AccountID)
        {
            InitializeComponent();

            _AccountID = AccountID;

            if (_AccountID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        private void _FillCurrenciesInComboBox()
        {
            cmbAccountCarrency.DataSource = clsCurrency.GetAllCurrencies();
            cmbAccountCarrency.DisplayMember = "Name";
            cmbAccountCarrency.ValueMember = "CurrencyID";
        }

        private void _FillClientsInComboBox()
        {
            cmbClientName.DataSource = clsClient.GetCostomClients();
            cmbClientName.DisplayMember = "الاسم";
            cmbClientName.ValueMember = "#";
        }


        private void _LoadData()
        {
            _FillCurrenciesInComboBox();
            _FillClientsInComboBox();

            if (_Mode == enMode.AddNew)
            {
                this.Text = "شاشة اضافة حساب جديد";
                _Account = new clsAccount();
                return;
            }

            _Account = clsAccount.Find(_AccountID);

            if (_Account == null)
            {
                MessageBox.Show("This form will be closed because No Account with ID = " + _AccountID);
                this.Close();
                return;
            }
            this.Text = "شاشة تعديل بيانات الحساب";
            lblAccountID.Text = _AccountID.ToString();
            cmbClientName.SelectedValue = _Account.ClientID;
            cmbAccountCarrency.SelectedValue = _Account.AccountCurrency;
            lblAccountNum.Text = _Account.AccountNumber.ToString();
            txtAccountBlan.Text = _Account.AccountBalance.ToString();
            txtNote.Text = _Account.Note;
        }

        private void frmAddEditAccount_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _Account.AccountID = Convert.ToInt32(lblAccountID.Text);
            _Account.AccountCurrency = (int)cmbAccountCarrency.SelectedValue;

            _Account.AccountNumber = Convert.ToInt32(lblAccountNum.Text);

            _Account.AccountBalance = Convert.ToDecimal(txtAccountBlan.Text);
            _Account.Note = txtNote.Text;

            if (_Account.Save())
            {
                MessageBox.Show("تم حفظ بيانات الحساب بنجاح ✅");
                _Mode = enMode.Update;
                lblAccountID.Text = _Account.AccountID.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("خطأ: لم يتم حفظ البيانات !!! ❎");
            }
        }
    }
}
