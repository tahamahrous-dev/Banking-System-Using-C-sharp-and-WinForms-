using BankBusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace BankSys_WinForms.Transaction
{
    public partial class frmAddEditTransactions : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _TransactionID;
        clsTransaction _Transaction;

        public frmAddEditTransactions(int TransactionID)
        {
            InitializeComponent();
            _TransactionID = TransactionID;
            _Mode = _TransactionID == -1 ? enMode.AddNew : enMode.Update;
        }

        private void _LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = "شاشة اضافة عملية جديدة";
                _Transaction = new clsTransaction();
                lblTransactionNumRef.Text = clsTransaction.GenerateTransactionNumber().ToString();
                return;
            }

            _Transaction = clsTransaction.Find(_TransactionID);

            if (_Transaction == null)
            {
                MessageBox.Show("لا توجد عملية بهذا المعرف: " + _TransactionID, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            this.Text = "شاشة تعديل بيانات العملية";
            lblTransactionNumRef.Text = _Transaction.TransactionRefNum.ToString();

            // Load client data
            _LoadClientData();

            cmbTransactionType.Text = _Transaction.TransactionType;
            txtAmount.Text = _Transaction.Amount.ToString("N2");
            dtpTransactionDate.Value = _Transaction.TransactionDate;
            txtCommission.Text = _Transaction.Commission?.ToString("N2") ?? "0";
        }

        private void _LoadAccountsFromData(int ClientID)
        {
            try
            {
                // Load Accounts for combobox
                DataTable accounts = clsAccount.GetAllAccounts(ClientID);
                cmbAccount.DataSource = accounts;
                cmbAccount.DisplayMember = "AccountName";
                cmbAccount.ValueMember = "AccountID";





                if (_Mode == enMode.Update)
                {
                    // Select the account in combobox
                    cmbAccount.SelectedValue = _Transaction.AccountID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل بيانات الحسابات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _LoadAccountsToData(int ClientID)
        {
            try
            {
                // Load Accounts for combobox
                DataTable accounts = clsAccount.GetAllAccounts(ClientID);
                cmbAccountTo.DataSource = accounts;
                cmbAccountTo.DisplayMember = "AccountName";
                cmbAccountTo.ValueMember = "AccountID";





                if (_Mode == enMode.Update)
                {
                    // Select the account in combobox
                    cmbAccountTo.SelectedValue = _Transaction.AccountID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل بيانات الحسابات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _LoadClientData()
        {
            try
            {
                // Load clients for combobox
                DataTable clients = clsClient.GetCostomClients();
                cmbClientName.DataSource = clients;
                cmbClientName.DisplayMember = "الاسم";
                cmbClientName.ValueMember = "#";

                cmbTransferToClient.DataSource = clients.Copy();
                cmbTransferToClient.DisplayMember = "الاسم";
                cmbTransferToClient.ValueMember = "#";


               

                if (_Mode == enMode.Update)
                {
                    // Select the client in combobox
                    cmbClientName.SelectedValue = _Transaction.AccountID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل بيانات العملاء: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddEditTransactions_Load(object sender, EventArgs e)
        {
            _LoadClientData();
            _LoadData();

            // Set default transaction type
            cmbTransactionType.SelectedIndex = 0;
            cmbAccount.SelectedItem = null;
            cmbTransferToClient.SelectedItem = null;
            // Hide transfer controls initially
            ToggleTransferControls(false);
        }

        private void ToggleTransferControls(bool show)
        {
            lblTransferTo.Visible = show;
            cmbTransferToClient.Visible = show;
            label21.Visible = show;
            txtCommission.Visible = show;
            label4.Visible = show;
            cmbAccountTo.Visible = show;
        }

        private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cmbTransactionType.Text;

            switch (selectedType)
            {
                case "سحب":
                case "إيداع":
                    ToggleTransferControls(false);
                    txtCommission.Text = "0";
                    break;

                case "تحويل":
                    ToggleTransferControls(true);
                    break;
            }
        }

        private void cmbClientName_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbClientName.SelectedValue != null && cmbClientName.SelectedValue is int)
            {
                int selectedClientID = (int)cmbClientName.SelectedValue;
                _LoadAccountsFromData(selectedClientID);
            }
        }

        private void cmbTransferToClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTransferToClient.SelectedValue != null && cmbTransferToClient.SelectedValue is int)
            {
                int selecteAccountID = (int)cmbTransferToClient.SelectedValue;
                _LoadAccountsToData(selecteAccountID);
            }
        }

        private bool ValidateData()
        {
            if (cmbClientName.SelectedValue == null)
            {
                MessageBox.Show("يرجى اختيار العميل", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbClientName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cmbTransactionType.Text))
            {
                MessageBox.Show("يرجى اختيار نوع العملية", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTransactionType.Focus();
                return false;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("يرجى إدخال مبلغ صحيح أكبر من الصفر", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return false;
            }

            if (cmbTransactionType.Text == "تحويل")
            {
                if (cmbTransferToClient.SelectedValue == null)
                {
                    MessageBox.Show("يرجى اختيار العميل المحول إليه", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbTransferToClient.Focus();
                    return false;
                }

                if (cmbClientName.SelectedValue.Equals(cmbTransferToClient.SelectedValue))
                {
                    MessageBox.Show("لا يمكن التحويل لنفس الحساب", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbTransferToClient.Focus();
                    return false;
                }

                if (!decimal.TryParse(txtCommission.Text, out decimal commission) || commission < 0)
                {
                    MessageBox.Show("يرجى إدخال عمولة صحيحة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCommission.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
                return;

            try
            {
                int AccountID = Convert.ToInt32(cmbAccount.SelectedValue);
                decimal amount = Convert.ToDecimal(txtAmount.Text);
                decimal commission = Convert.ToDecimal(txtCommission.Text);

                bool success = false;
                string message = "";
                clsGlobal.CurrentUser = clsUser.Find(442);

                switch (cmbTransactionType.Text)
                {
                    case "إيداع":
                        var deposit = clsTransaction.AddDepositTransaction(AccountID, amount, clsGlobal.CurrentUser.UserID);
                        success = deposit != null;
                        message = success ? "تمت عملية الإيداع بنجاح ✅" : "فشلت عملية الإيداع ❌";
                        break;

                    case "سحب":
                        // Check if client has sufficient balance
                        clsAccount account = clsAccount.Find(AccountID);
                        if (account != null && account.AccountBalance >= amount)
                        {
                            var withdraw = clsTransaction.AddWithdrawTransaction(AccountID, amount, clsGlobal.CurrentUser.UserID);
                            success = withdraw != null;
                            message = success ? "تمت عملية السحب بنجاح ✅" : "فشلت عملية السحب ❌";
                        }
                        else
                        {
                            MessageBox.Show("الرصيد غير كافي لإتمام عملية السحب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;

                    case "تحويل":
                        int toAccountID = Convert.ToInt32(cmbAccountTo.SelectedValue);
                        success = clsTransaction.AddTransferTransaction(AccountID, toAccountID, amount, commission, clsGlobal.CurrentUser.UserID);
                        message = success ? "تمت عملية التحويل بنجاح ✅" : "فشلت عملية التحويل ❌";
                        break;
                }

                if (success)
                {
                    MessageBox.Show(message, "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtCommission_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}