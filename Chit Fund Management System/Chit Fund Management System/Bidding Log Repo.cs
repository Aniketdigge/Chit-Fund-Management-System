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
    public partial class Bidding_Log_Repo : Form
    {
        public Bidding_Log_Repo()
        {
            InitializeComponent();
        }

        private void Bidding_Log_Repo_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"F:\Chit-Fund-Management-System\Chit Fund Management System\Chit Fund Management System\Bidding Log Report.rpt");
            crv_bidding_log_repo.ReportSource = cryRpt;
            crv_bidding_log_repo.Refresh();
            cryRpt.Refresh();
        }
    }
}
