using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankBusinessLayer;
using BankSys_WinForms.Clients;
using Guna.UI2.WinForms;

namespace BankSys_WinForms
{
    public partial class frmClient : Form
    {

        public frmClient()
        {
            InitializeComponent();
        }


        private void _RefreshClientsList()
        {
            dgvClients.DataSource = clsClient.GetCostomClients();
        }

        private void frmClients_Load(object sender, EventArgs e)
        {
            _RefreshClientsList();

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditClient frmAdd_Update = new frmAddEditClient(-1);
            frmAdd_Update.ShowDialog();

            _RefreshClientsList();
        }

        private void FilterClients()
        {
            string searchText = txtFilter.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                (dgvClients.DataSource as DataTable).DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvClients.Rows.Count.ToString();
                return;
            }

            // التحقق إذا كان الإدخال رقم ClientID
            if (int.TryParse(searchText, out int clientId))
            {
                (dgvClients.DataSource as DataTable).DefaultView.RowFilter =
                    $"ClientID = {clientId}";
            }
            else
            {
                // تصفية حسب الاسم الأول أو اسم العائلة
                (dgvClients.DataSource as DataTable).DefaultView.RowFilter =
                    $"[الاسم] LIKE '%{searchText}%'";
            }

            lblRecordsCount.Text = (dgvClients.DataSource as DataTable).DefaultView.Count.ToString();
        }

        private void txtSertch_TextChanged(object sender, EventArgs e)
        {
            FilterClients();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

                if (MessageBox.Show("هل انت متأكد من حذف العميل رقم [" + dgvClients.CurrentRow.Cells[1].Value + "]؟؟؟", "تأكيد الحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

                {

                    //Perform Delele and refresh
                    if (clsClient.DeleteClient((int)dgvClients.CurrentRow.Cells[0].Value))
                    {
                        MessageBox.Show("✅ تم ازالة العميل بنجاح ");
                        _RefreshClientsList();
                    }

                    else
                        MessageBox.Show("فشل حذف العميل،،، هناك خطأ مـــا!!! ❎");

                }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvClients.CurrentRow.Cells[0].Value.ToString(), out int id))
            {
                frmAddEditClient frm = new frmAddEditClient((int)dgvClients.CurrentRow.Cells[0].Value);
                frm.ShowDialog();

                _RefreshClientsList();


            }
            else
            {
                MessageBox.Show("يجب عليك اولاً تحديد صف !!!", "خطأ ❎", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
