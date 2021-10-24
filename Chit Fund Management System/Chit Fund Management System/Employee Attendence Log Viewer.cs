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
    public partial class Employee_Attendence_Log_Viewer : Form
    {
        public Employee_Attendence_Log_Viewer()
        {
            InitializeComponent();
        }

        private void Employee_Attendence_Log_Viewer_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"F:\Chit-Fund-Management-System\Chit Fund Management System\Chit Fund Management System\Employee Attendence Log.rpt");
            crv_employee_attencence_log.ReportSource = cryRpt;
            crv_employee_attencence_log.Refresh();
            cryRpt.Refresh();
        }
    }
}
