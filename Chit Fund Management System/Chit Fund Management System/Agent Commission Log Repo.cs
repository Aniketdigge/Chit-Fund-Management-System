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
    public partial class Agent_Commission_Log_Repo : Form
    {
        public Agent_Commission_Log_Repo()
        {
            InitializeComponent();
        }

        private void Agent_Commission_Log_Repo_Load(object sender, EventArgs e)
        {
            ReportDocument cryst = new ReportDocument();
            cryst.Load(@"F:\Chit-Fund-Management-System\Chit Fund Management System\Chit Fund Management System\Agent Commission Log Report.rpt");
            crv_agent_commission_log_report.ReportSource = cryst;
            crv_agent_commission_log_report.Refresh();
            cryst.Refresh();
        }
    }
}
