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

namespace Chit_Fund_Management_System
{
    public partial class Employee_Salary_Slip : Form
    {
        public static string employee_id = " ";
        public static string employee_name = " ";
        public static string mob_no = " ";
        public static string email = " ";
        public static string designation = " ";
        public static string salary_per_day = " ";
        public static string present_days = " ";
        public static string gross_salary = " ";
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
                double salary_per_day, present, gross_salary;
                salary_per_day = double.Parse(tb_salary_per_day.Text);
                present = double.Parse(tb_salary_present_days.Text);
                gross_salary = salary_per_day * present;
                tb_salary_gross_salary.Text = gross_salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void bt_salary_save_Click(object sender, EventArgs e)
        {
            
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
        }

        private void bt_salary_close_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }

        private void bt_salary_slip_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_salary_pay_Click(object sender, EventArgs e)
        {
            try
            {
                employee_id = tb_salary_employee_id.Text;
                employee_name = tb_salary_employee_name.Text;
                mob_no = tb_salary_employee_mob.Text;
                email = tb_salary_employee_email.Text;
                designation = tb_salary_employee_designation.Text;
                salary_per_day = tb_salary_per_day.Text;
                present_days = tb_salary_present_days.Text;
                gross_salary = tb_salary_gross_salary.Text;
                date_of_slip = dtp_salary_received_date.Value.ToString("d-M-yyyy");

                Employee_Payment employee_Payment = new Employee_Payment();
                employee_Payment.Show();
                this.Hide();
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.ToString());
            }
        }
    }
}
