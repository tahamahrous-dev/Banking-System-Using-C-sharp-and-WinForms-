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
using BankSys_WinForms.Clients;
using Guna.UI2.WinForms;


namespace BankSys_WinForms.Accounts
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }


        private void _RefreshAccountsList()
        {
            dgvAccounts.DataSource = clsAccount.GetCostomAccounts();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            _RefreshAccountsList();
            lblRecordsCount.Text = dgvAccounts.Rows.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditAccount frmAdd_Update = new frmAddEditAccount(-1);
            frmAdd_Update.ShowDialog();
            _RefreshAccountsList();
        }

        private void FilterAccounts()
        {
            string searchText = txtFilter.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                (dgvAccounts.DataSource as DataTable).DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvAccounts.Rows.Count.ToString();
                return;
            }

            // التحقق إذا كان الإدخال رقم AccountID
            if (int.TryParse(searchText, out int accountId))
            {
                (dgvAccounts.DataSource as DataTable).DefaultView.RowFilter =
                    $"AccountID = {accountId}";
            }
            else if (int.TryParse(searchText, out int clientId))
            {
                // تصفية حسب ClientID
                (dgvAccounts.DataSource as DataTable).DefaultView.RowFilter =
                    $"ClientID = {clientId}";
            }
            else
            {
                // إلغاء التصفية إذا لم يكن رقم
                (dgvAccounts.DataSource as DataTable).DefaultView.RowFilter = "";
            }

            lblRecordsCount.Text = (dgvAccounts.DataSource as DataTable).DefaultView.Count.ToString();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            FilterAccounts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.CurrentRow == null)
            {
                MessageBox.Show("يجب عليك اولاً تحديد حساب لحذفه!", "خطأ ❎", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("هل انت متأكد من حذف الحساب رقم [" + dgvAccounts.CurrentRow.Cells[0].Value + "]؟", "تأكيد الحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsAccount.DeleteAccount((int)dgvAccounts.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("✅ تم حذف الحساب بنجاح ");
                    _RefreshAccountsList();
                }
                else
                {
                    MessageBox.Show("فشل حذف الحساب،،، هناك خطأ مـــا!!! ❎");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.CurrentRow == null)
            {
                MessageBox.Show("يجب عليك اولاً تحديد حساب لتعديله!", "خطأ ❎", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(dgvAccounts.CurrentRow.Cells[0].Value.ToString(), out int id))
            {
                frmAddEditAccount frm = new frmAddEditAccount((int)dgvAccounts.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
                _RefreshAccountsList();
            }
            else
            {
                MessageBox.Show("يجب عليك اولاً تحديد صف !!!", "خطأ ❎", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _RefreshAccountsList();
            txtFilter.Clear();
        }
    }
}
