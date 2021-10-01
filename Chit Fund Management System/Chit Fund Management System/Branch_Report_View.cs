using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Chit_Fund_Management_System
{
    public partial class Branch_Report_View : Form
    {
        public Branch_Report_View()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Branch_Report_View_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"F:\Chit-Fund-Management-System\Chit Fund Management System\Chit Fund Management System\Branch Report.rpt");
            crv_branch_report_view.ReportSource = cryRpt;
            crv_branch_report_view.Refresh();
            cryRpt.Refresh();
        }
    }
}
