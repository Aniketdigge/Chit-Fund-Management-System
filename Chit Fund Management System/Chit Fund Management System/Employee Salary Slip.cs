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
    public partial class Employee_Salary_Slip : Form
    {
        public static string employee_id = " ";
        public static string employee_name = " ";
        public static string mob_no = " ";
        public static string email = " ";
        public static string designation = " ";
        public static string present_days = " ";
        public static string gross_salary = " ";
        public static string tds = " ";
        public static string pf = " ";
        public static string net_salary = " ";
        public static string date_of_slip = " ";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public Employee_Salary_Slip()
        {
            InitializeComponent();
        }

        private void bt_salary_calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double gross_salary, net_salary, tds, pf;
                gross_salary = double.Parse(tb_salary_gross_salary.Text);
                tds = 0.05 * gross_salary;
                pf = 0.12 * gross_salary;
                net_salary = gross_salary - (tds + pf);
                tb_salary_tds.Text = tds.ToString();
                tb_salary_pf.Text = pf.ToString();
                tb_salary_net_salary.Text = net_salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void bt_salary_save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into Employee_SalaryTB(Employee_ID, Employee_Name, Employee_gross_salary, Employee_tds, Employee_pf, Employee_net_salary, Date_of_slip, Employee_designation) values" +
                    "(@EMPid, @EMPname, @employeegrosssalary, @employeetds, @employeepf, @employeenetsalary, @dateofslip, @employeedesignation)", con);
                cmd.Parameters.AddWithValue("@EMPid", tb_salary_employee_id.Text);
                cmd.Parameters.AddWithValue("@EMPname", tb_salary_employee_name.Text);
                cmd.Parameters.AddWithValue("@employeegrosssalary", tb_salary_gross_salary.Text);
                cmd.Parameters.AddWithValue("@employeetds", tb_salary_tds.Text);
                cmd.Parameters.AddWithValue("@employeepf", tb_salary_pf.Text);
                cmd.Parameters.AddWithValue("@employeenetsalary", tb_salary_net_salary.Text);
                cmd.Parameters.AddWithValue("@dateofslip", dtp_salary_received_date.Text);
                cmd.Parameters.AddWithValue("@employeedesignation", tb_salary_employee_designation.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Salary Details Saved Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_salary_search_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataReader dr;
                DataTable dt = new DataTable();
                con.Open();
                cmd = new OleDbCommand("select [Employee_Name], [Employee_Mobile], [Employee_Email], [Employee_Designation]" +
                    "from EmployeeTB where [Employee_ID]=@employeeid", con);
                cmd.Parameters.AddWithValue("@employeeid", tb_salary_employee_id.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tb_salary_employee_name.Text = (dr["Employee_Name"].ToString());
                    tb_salary_employee_mob.Text = (dr["Employee_Mobile"].ToString());
                    tb_salary_employee_email.Text = (dr["Employee_Email"].ToString());
                    tb_salary_employee_designation.Text = (dr["Employee_Designation"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_salary_clear_Click(object sender, EventArgs e)
        {
            tb_salary_employee_id.Clear();
            tb_salary_employee_name.Clear();
            tb_salary_employee_mob.Clear();
            tb_salary_employee_email.Clear();
            tb_salary_employee_designation.Clear();
            tb_salary_present_days.Clear();
            tb_salary_gross_salary.Clear();
            tb_salary_tds.Clear();
            tb_salary_pf.Clear();
            tb_salary_net_salary.Clear();
        }

        private void bt_salary_close_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }

        private void bt_salary_slip_Click(object sender, EventArgs e)
        {
            try
            {
                employee_id = tb_salary_employee_id.Text;
                employee_name = tb_salary_employee_name.Text;
                mob_no = tb_salary_employee_mob.Text;
                email = tb_salary_employee_email.Text;
                designation = tb_salary_employee_designation.Text;
                present_days = tb_salary_present_days.Text;
                gross_salary = tb_salary_gross_salary.Text;
                tds = tb_salary_tds.Text;
                pf = tb_salary_pf.Text;
                net_salary = tb_salary_net_salary.Text;
                date_of_slip = dtp_salary_received_date.Value.ToString("d-M-yyyy");

                Employee_Salary_Slip_Print employee_Salary_Slip_Print = new Employee_Salary_Slip_Print();
                employee_Salary_Slip_Print.Show();
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.ToString());
            }
        }
    }
}
