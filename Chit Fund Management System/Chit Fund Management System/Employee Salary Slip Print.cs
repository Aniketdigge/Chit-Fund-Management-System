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
using CrystalDecisions.Shared;

namespace Chit_Fund_Management_System
{
    public partial class Employee_Salary_Slip_Print : Form
    {
        public Employee_Salary_Slip_Print()
        {
            InitializeComponent();
        }

        private void Employee_Salary_Slip_Print_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument cryst = new ReportDocument();
                cryst.Load(@"F:\Chit-Fund-Management-System\Chit Fund Management System\Chit Fund Management System\Employee Salary Slip Repo.rpt");
                TextObject date_of_payment = (TextObject)cryst.ReportDefinition.Sections["Section2"].ReportObjects["date_of_payment"];
                date_of_payment.Text = Employee_Salary_Slip.date_of_slip;
                TextObject employee_id = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["employee_id"];
                employee_id.Text = Employee_Salary_Slip.employee_id;
                TextObject employee_name = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["employee_name"];
                employee_name.Text = Employee_Salary_Slip.employee_name;
                TextObject mob_no = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["mob_no"];
                mob_no.Text = Employee_Salary_Slip.mob_no;
                TextObject email = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["email"];
                email.Text = Employee_Salary_Slip.email;
                TextObject designation = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["designation"];
                designation.Text = Employee_Salary_Slip.designation;
                TextObject present_days = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["present_days"];
                present_days.Text = Employee_Salary_Slip.present_days;
                TextObject gross_salary = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["gross_salary"];
                gross_salary.Text = Employee_Salary_Slip.gross_salary;
                TextObject tds = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["tds"];
                tds.Text = Employee_Salary_Slip.tds;
                TextObject pf = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["pf"];
                pf.Text = Employee_Salary_Slip.pf;
                TextObject net_salary = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["net_salary"];
                net_salary.Text = Employee_Salary_Slip.net_salary;
                TextObject amount_payble = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["amount_payble"];
                amount_payble.Text = Employee_Salary_Slip.net_salary;
                crv_salary_slip.ReportSource = cryst;
                crv_salary_slip.Refresh();
                cryst.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
