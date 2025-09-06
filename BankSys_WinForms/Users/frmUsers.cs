using BankBusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace BankSys_WinForms.Users
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void _RefreshUsersList()
        {
            dgvUsers.DataSource = clsUser.GetCostomUsers();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditUser frmAdd_Update = new frmAddEditUser(-1);
            frmAdd_Update.ShowDialog();

            _RefreshUsersList();
        }

        private void FilterUsers()
        {
            string searchText = txtFilter.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                (dgvUsers.DataSource as DataTable).DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
                return;
            }

            // التحقق إذا كان الإدخال رقم UserID
            if (int.TryParse(searchText, out int UserId))
            {
                (dgvUsers.DataSource as DataTable).DefaultView.RowFilter =
                    $"UserID = {UserId}";
            }
            else
            {
                // تصفية حسب الاسم الأول أو اسم العائلة
                (dgvUsers.DataSource as DataTable).DefaultView.RowFilter =
                    $"[الاسم] LIKE '%{searchText}%'";
            }

            lblRecordsCount.Text = (dgvUsers.DataSource as DataTable).DefaultView.Count.ToString();
        }

        private void txtSertch_TextChanged(object sender, EventArgs e)
        {
            FilterUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انت متأكد من حذف المستخدم [ " + dgvUsers.CurrentRow.Cells[3].Value + " ]؟؟؟", "تأكيد الحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsUser.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("✅ تم ازالة المستخدم بنجاح ");
                    _RefreshUsersList();
                }

                else
                    MessageBox.Show("فشل حذف المستخدم،،، هناك خطأ مـــا!!! ❎");

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvUsers.CurrentRow.Cells[0].Value.ToString(), out int id))
            {
                frmAddEditUser frm = new frmAddEditUser((int)dgvUsers.CurrentRow.Cells[0].Value);
                frm.ShowDialog();

                _RefreshUsersList();


            }
            else
            {
                MessageBox.Show("يجب عليك اولاً تحديد صف !!!", "خطأ ❎", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmUsers_Load_1(object sender, EventArgs e)
        {
            _RefreshUsersList();
        }
    }
}
