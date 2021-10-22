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
    public partial class Loan_Installment_Log_Viewer : Form
    {
        public Loan_Installment_Log_Viewer()
        {
            InitializeComponent();
        }

        private void Loan_Installment_Log_Viewer_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"F:\Chit-Fund-Management-System\Chit Fund Management System\Chit Fund Management System\Loan Installment Log Report.rpt");
            crv_loan_installment_log_viewer.ReportSource = cryRpt;
            crv_loan_installment_log_viewer.Refresh();
            cryRpt.Refresh();
        }
    }
}
