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
    public partial class Employee_Attendence : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public Employee_Attendence()
        {
            InitializeComponent();
        }

        private void bt_attendence_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into Employee_AttendenceTB(Employee_id, Employee_name, Employee_designation, Attendence, Attendence_date) values" +
                    "(@employeeid, @employeename, @employeedesignation, @attendence, @attendencedate)", con);
                cmd.Parameters.AddWithValue("@employeeid", tb_attendence_emp_id.Text);
                cmd.Parameters.AddWithValue("@employeename", tb_attendence_emp_name.Text);
                cmd.Parameters.AddWithValue("@employeedesignation", tb_attendence_emp_designation.Text);
                cmd.Parameters.AddWithValue("@attendence", cb_attendence_a_p.Text);
                cmd.Parameters.AddWithValue("@attendencedate", dtp_attendence_date.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Attendence Saved Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_attendence_search_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataReader dr;
                DataTable dt = new DataTable();
                con.Open();
                cmd = new OleDbCommand("select [Employee_Name], [Employee_Designation]" +
                    "from EmployeeTB where [Employee_ID]=@EMPid", con);
                cmd.Parameters.AddWithValue("@EMPid", tb_attendence_emp_id.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tb_attendence_emp_name.Text = (dr["Employee_Name"].ToString());
                    tb_attendence_emp_designation.Text = (dr["Employee_Designation"].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_attendence_clear_Click(object sender, EventArgs e)
        {
            tb_attendence_emp_id.Clear();
            tb_attendence_emp_name.Clear();
            tb_attendence_emp_designation.Clear();
        }

        private void bt_attendence_close_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }

        private void bt_attendence_log_Click(object sender, EventArgs e)
        {
            Employee_Attendence_Log_Viewer employee_Attendence_Log_Viewer = new Employee_Attendence_Log_Viewer();
            employee_Attendence_Log_Viewer.Show();
        }
    }
}
