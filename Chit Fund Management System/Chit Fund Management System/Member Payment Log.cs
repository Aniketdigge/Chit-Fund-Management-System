using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Chit_Fund_Management_System
{
    public partial class Member_Payment_Log : Form
    {
        public Member_Payment_Log()
        {
            InitializeComponent();
        }

        private void Member_Payment_Log_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"F:\Chit-Fund-Management-System\Chit Fund Management System\Chit Fund Management System\Member Payment Log Report.rpt");
            crv_member_payment_log.ReportSource = cryRpt;
            crv_member_payment_log.Refresh();
            cryRpt.Refresh();
        }
    }
}
