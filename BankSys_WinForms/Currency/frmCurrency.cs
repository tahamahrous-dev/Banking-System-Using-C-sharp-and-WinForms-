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

namespace BankSys_WinForms.Currency
{
    public partial class frmCurrency : Form
    {
        public frmCurrency()
        {
            InitializeComponent();
        }


        private void _RefreshCurrenciesList()
        {
            dgvCurrencies.DataSource = clsCurrency.GetCostomCurrencies();
        }

        private void frmCurrencies_Load(object sender, EventArgs e)
        {
            _RefreshCurrenciesList();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditCurrency frmAdd_Update = new frmAddEditCurrency(-1);
            frmAdd_Update.ShowDialog();

            _RefreshCurrenciesList();
        }

        private void FilterCurrencies()
        {
            string searchText = txtFilter.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                (dgvCurrencies.DataSource as DataTable).DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvCurrencies.Rows.Count.ToString();
                return;
            }

            // التحقق إذا كان الإدخال رقم CurrencyID
            if (int.TryParse(searchText, out int CurrencyId))
            {
                (dgvCurrencies.DataSource as DataTable).DefaultView.RowFilter =
                    $"CurrencyID = {CurrencyId}";
            }
            else
            {
                // تصفية حسب الاسم الأول أو اسم العائلة
                (dgvCurrencies.DataSource as DataTable).DefaultView.RowFilter =
                    $"[اسم العملة] LIKE '%{searchText}%'";
            }

            lblRecordsCount.Text = (dgvCurrencies.DataSource as DataTable).DefaultView.Count.ToString();
        }

        private void txtSertch_TextChanged(object sender, EventArgs e)
        {
            FilterCurrencies();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انت متأكد من حذف العملة [ " + dgvCurrencies.CurrentRow.Cells[3].Value + " ]؟؟؟", "تأكيد الحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsCurrency.DeleteCurrency((int)dgvCurrencies.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("✅ تم ازالة العملة بنجاح ");
                    _RefreshCurrenciesList();
                }

                else
                    MessageBox.Show("فشل حذف العملة،،، هناك خطأ مـــا!!! ❎");

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvCurrencies.CurrentRow.Cells[0].Value.ToString(), out int id))
            {
                frmAddEditCurrency frm = new frmAddEditCurrency((int)dgvCurrencies.CurrentRow.Cells[0].Value);
                frm.ShowDialog();

                _RefreshCurrenciesList();


            }
            else
            {
                MessageBox.Show("يجب عليك اولاً تحديد صف !!!", "خطأ ❎", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
