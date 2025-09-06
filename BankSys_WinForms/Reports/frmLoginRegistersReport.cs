using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace BankSys_WinForms.Reports
{
    public partial class frmLoginRegistersReport : Form
    {
        public frmLoginRegistersReport()
        {
            InitializeComponent();
        }

        private void frmLoginRegistersReport_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"D:\Dr.Mohammed_Abo-Hodowd\Course_18_C# & Database Connectivity\MyProjects\BankSys_WinForms\Reports\rptLoginRegisters.rpt"); // لو التقرير في نفس المشروع ضع المسار النسبي

            // إعداد الاتصال بقاعدة البيانات (إذا التقرير يحتاج)
            cryRpt.SetDatabaseLogon("username", "password", "serverName", "BankSysDB");

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
