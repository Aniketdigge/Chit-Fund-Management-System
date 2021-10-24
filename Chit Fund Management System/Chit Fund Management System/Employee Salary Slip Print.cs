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
                date_of_payment.Text = Employee_Payment.date_of_slip_ep;
                TextObject employee_id = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["employee_id"];
                employee_id.Text = Employee_Payment.employee_id_ep;
                TextObject employee_name = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["employee_name"];
                employee_name.Text = Employee_Payment.employee_name_ep;
                TextObject mob_no = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["mob_no"];
                mob_no.Text = Employee_Payment.mob_no_ep;
                TextObject email = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["email"];
                email.Text = Employee_Payment.email_ep;
                TextObject designation = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["designation"];
                designation.Text = Employee_Payment.designation_ep;
                TextObject pyament_method = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["pyament_method"];
                pyament_method.Text = Employee_Payment.payment_method_ep;
                TextObject present_days = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["present_days"];
                present_days.Text = Employee_Payment.present_days_ep;
                TextObject salary_per_day = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["salary_per_day"];
                salary_per_day.Text = Employee_Payment.salary_per_day_ep;
                TextObject gross_salary = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["gross_salary"];
                gross_salary.Text = Employee_Payment.gross_salary_ep;
                TextObject tds = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["tds"];
                tds.Text = Employee_Payment.tds_ep;
                TextObject pf = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["pf"];
                pf.Text = Employee_Payment.pf_ep;
                TextObject net_salary = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["net_salary"];
                net_salary.Text = Employee_Payment.net_salary_ep;
                TextObject amount_payble = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["amount_payble"];
                amount_payble.Text = Employee_Payment.net_salary_ep;
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
