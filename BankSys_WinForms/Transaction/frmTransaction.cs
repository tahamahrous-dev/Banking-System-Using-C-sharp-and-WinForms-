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

namespace BankSys_WinForms.Transaction
{
    public partial class frmTransaction : Form
    {
        public frmTransaction()
        {
            InitializeComponent();
        }


        private void _RefreshTransactionsList()
        {
            dgvTransactions.DataSource = clsTransaction.GetCostomTransactions();
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            _RefreshTransactionsList();
            lblRecordsCount.Text = dgvTransactions.Rows.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditTransactions frmAdd_Update = new frmAddEditTransactions(-1);
            frmAdd_Update.ShowDialog();

            _RefreshTransactionsList();
        }

        //private void FilterTransactions()
        //{
        //    string searchText = txtFilter.Text.Trim();

        //    if (string.IsNullOrEmpty(searchText))
        //    {
        //        (dgvTransactions.DataSource as DataTable).DefaultView.RowFilter = "";
        //        lblRecordsCount.Text = dgvTransactions.Rows.Count.ToString();
        //        return;
        //    }

        //    // التحقق إذا كان الإدخال رقم ClientID
        //    if (int.TryParse(searchText, out int Transactionsid))
        //    {
        //        (dgvTransactions.DataSource as DataTable).DefaultView.RowFilter =
        //            $"TransactionID = {Transactionsid}";
        //    }
        //    else
        //    {
        //        // تصفية حسب الاسم الأول أو اسم العائلة
        //        (dgvTransactions.DataSource as DataTable).DefaultView.RowFilter =
        //            $"[الاسم] LIKE '%{searchText}%'";
        //    }

        //    lblRecordsCount.Text = (dgvTransactions.DataSource as DataTable).DefaultView.Count.ToString();
        //}


        private void FilterTransactions()
        {
            string searchText = txtFilter.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                (dgvTransactions.DataSource as DataTable).DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvTransactions.Rows.Count.ToString();
                return;
            }

            // Check if input is a TransactionID
            if (int.TryParse(searchText, out int transactionId))
            {
                (dgvTransactions.DataSource as DataTable).DefaultView.RowFilter =
                    $"TransactionID = {transactionId}";
            }
            // Check if input is an AccountID
            else if (int.TryParse(searchText, out int accountId))
            {
                (dgvTransactions.DataSource as DataTable).DefaultView.RowFilter =
                    $"AccountID = {accountId}";
            }
            else
            {
                // Filter by TransactionType
                (dgvTransactions.DataSource as DataTable).DefaultView.RowFilter =
                    $"[TransactionType] LIKE '%{searchText}%'";
            }

            lblRecordsCount.Text = (dgvTransactions.DataSource as DataTable).DefaultView.Count.ToString();
        }


        private void txtSertch_TextChanged(object sender, EventArgs e)
        {
            FilterTransactions();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انت متأكد من حذف العملية رقم [" + dgvTransactions.CurrentRow.Cells[0].Value + "]؟؟؟", "تأكيد الحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsClient.DeleteClient((int)dgvTransactions.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("✅ تم ازالة العملية بنجاح ");
                    _RefreshTransactionsList();
                }

                else
                    MessageBox.Show("فشل حذف العملية،،، هناك خطأ مـــا!!! ❎");

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvTransactions.CurrentRow.Cells[0].Value.ToString(), out int id))
            {
                frmAddEditTransactions frm = new frmAddEditTransactions((int)dgvTransactions.CurrentRow.Cells[0].Value);
                frm.ShowDialog();

                _RefreshTransactionsList();


            }
            else
            {
                MessageBox.Show("يجب عليك اولاً تحديد صف !!!", "خطأ ❎", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
