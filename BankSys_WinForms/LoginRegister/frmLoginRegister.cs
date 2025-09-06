using BankBusinessLayer;
using BankSys_WinForms.Reports;
using System;
using System.Data;
using System.Windows.Forms;


namespace BankSys_WinForms.LoginRegister
{
    public partial class frmLoginRegister : Form
    {
        public frmLoginRegister()
        {
            InitializeComponent();
        }


        private void _LoadLoginRegisters()
        {
            DataTable dt = clsLoginRegister.GetAllLoginRegisters();
            dgvLoginRegisters.DataSource = dt;

            lblRecordsCount.Text = dt.Rows.Count.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // هنا ممكن تضيف كود طباعة DataGridView
                MessageBox.Show("🚀 سيتم تنفيذ الطباعة (يمكنك إضافة كود Crystal Reports أو RDLC هنا)");
            }
        }

        private void frmLoginRegister_Load(object sender, EventArgs e)
        {
            _LoadLoginRegisters();
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            frmLoginRegistersReport report = new frmLoginRegistersReport();
            report.ShowDialog();
        }
    }
}

