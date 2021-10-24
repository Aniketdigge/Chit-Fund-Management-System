using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Chit_Fund_Management_System
{
    public partial class Employee_Payment : Form
    {
        public static string employee_id_ep = " ";
        public static string employee_name_ep = " ";
        public static string mob_no_ep = " ";
        public static string email_ep = " ";
        public static string designation_ep = " ";
        public static string payment_method_ep = " ";
        public static string salary_per_day_ep = " ";
        public static string present_days_ep = " ";
        public static string gross_salary_ep = " ";
        public static string tds_ep = " ";
        public static string pf_ep = " ";
        public static string net_salary_ep = " ";
        public static string date_of_slip_ep = " ";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public Employee_Payment()
        {
            InitializeComponent();
        }

        private void bt_salary_save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into Employee_SalaryTB(Employee_ID, Employee_Name, Salary_per_day, Employee_gross_salary, Employee_tds, Employee_pf, Employee_net_salary, Payment_method, Date_of_slip, Employee_designation) values" +
                    "(@EMPid, @EMPname, @salaryperday, @employeegrosssalary, @employeetds, @employeepf, @employeenetsalary, @paymentmethod, @dateofslip, @employeedesignation)", con);
                cmd.Parameters.AddWithValue("@EMPid", lb_ep_employee_id.Text);
                cmd.Parameters.AddWithValue("@EMPname", lb_ep_employee_name.Text);
                cmd.Parameters.AddWithValue("@salaryperday", lb_ep_salary_per_day.Text);
                cmd.Parameters.AddWithValue("@employeegrosssalary", lb_ep_gross_salary.Text);
                cmd.Parameters.AddWithValue("@employeetds", lb_ep_tds.Text);
                cmd.Parameters.AddWithValue("@employeepf", lb_ep_pf.Text);
                cmd.Parameters.AddWithValue("@employeenetsalary", lb_ep_net_salary.Text);
                cmd.Parameters.AddWithValue("@paymentmethod", cb_ep_payment_method.Text);
                cmd.Parameters.AddWithValue("@dateofslip", lb_ep_date_of_payment.Text);
                cmd.Parameters.AddWithValue("@employeedesignation", lb_ep_employee_designation.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Salary Details Saved Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_salary_calculate_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_salary_close_Click(object sender, EventArgs e)
        {
            Employee_Salary_Slip employee_Salary_Slip = new Employee_Salary_Slip();
            employee_Salary_Slip.Show();
            this.Hide();
        }

        private void bt_salary_slip_Click(object sender, EventArgs e)
        {
            try
            {
                employee_id_ep = lb_ep_employee_id.Text;
                employee_name_ep = lb_ep_employee_name.Text;
                mob_no_ep = lb_ep_employee_mob.Text;
                email_ep = lb_ep_employee_email.Text;
                designation_ep = lb_ep_employee_designation.Text;
                payment_method_ep = cb_ep_payment_method.Text;
                salary_per_day_ep = lb_ep_salary_per_day.Text;
                present_days_ep = lb_ep_salary_per_day.Text;
                gross_salary_ep = lb_ep_gross_salary.Text;
                tds_ep = lb_ep_tds.Text;
                pf_ep = lb_ep_pf.Text;
                net_salary_ep = lb_ep_net_salary.Text;
                date_of_slip_ep = lb_ep_date_of_payment.Text;

                Employee_Salary_Slip_Print employee_Salary_Slip_Print = new Employee_Salary_Slip_Print();
                employee_Salary_Slip_Print.Show();
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.ToString());
            }
        }

        private void Employee_Payment_Load(object sender, EventArgs e)
        {
            lb_ep_employee_id.Text = Employee_Salary_Slip.employee_id;
            lb_ep_employee_name.Text = Employee_Salary_Slip.employee_name;
            lb_ep_employee_mob.Text = Employee_Salary_Slip.mob_no;
            lb_ep_employee_email.Text = Employee_Salary_Slip.email;
            lb_ep_employee_designation.Text = Employee_Salary_Slip.designation;
            lb_ep_salary_per_day.Text = Employee_Salary_Slip.salary_per_day;
            lb_ep_present_days.Text = Employee_Salary_Slip.present_days;
            lb_ep_gross_salary.Text = Employee_Salary_Slip.gross_salary;
            lb_ep_date_of_payment.Text = Employee_Salary_Slip.date_of_slip;

            double gross, tds, pf, net, add;
            gross = double.Parse(lb_ep_gross_salary.Text);
            tds = 0.05 * gross;
            pf = 0.12 * gross;
            add = tds + pf;
            net = gross - add;
            lb_ep_tds.Text = tds.ToString();
            lb_ep_pf.Text = pf.ToString();
            lb_ep_net_salary.Text = net.ToString();
        }
    }
}
