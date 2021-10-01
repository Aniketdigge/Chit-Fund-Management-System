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
    public partial class Member_Transaction_Log_Repo : Form
    {
        public Member_Transaction_Log_Repo()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Member_Transaction_Log_Repo_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"F:\Chit-Fund-Management-System\Chit Fund Management System\Chit Fund Management System\Member Transaction Log Report.rpt");
            crv_member_transaction_log_report.ReportSource = cryRpt;
            crv_member_transaction_log_report.Refresh();
            cryRpt.Refresh();
        }
    }
}
