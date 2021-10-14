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
    public partial class Salary_Payment_Repo : Form
    {
        public Salary_Payment_Repo()
        {
            InitializeComponent();
        }

        private void Salary_Payment_Repo_Load(object sender, EventArgs e)
        {
            ReportDocument cryst = new ReportDocument();
            cryst.Load(@"F:\Chit-Fund-Management-System\Chit Fund Management System\Chit Fund Management System\Salary Payment Report.rpt");
            crv_salary_report.ReportSource = cryst;
            crv_salary_report.Refresh();
            cryst.Refresh();
        }
    }
}
