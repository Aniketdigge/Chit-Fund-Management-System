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
    public partial class EmployeeProfile : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public EmployeeProfile()
        {
            InitializeComponent();
        }

        private void ADDEMP_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into Employee_TB(Employee_ID, Employee_Name, Employee_Address, Employee_Mobile, Employee_Designation, Employee_Email, Branch_ID, Date_of_Joining) values" +
                    "(@EMPid, @EMPname, @EMPaddress, @EMPmobileno, @EMPdesignation, @EMPemail, @EBranchid, @EMPDOJ)", con);
                cmd.Parameters.AddWithValue("@EMPid", Emp_ID.Text);
                cmd.Parameters.AddWithValue("@EMPname", EMP_Name.Text);
                cmd.Parameters.AddWithValue("@EMPaddress", Emp_Address.Text);
                cmd.Parameters.AddWithValue("@EMPmobileno", Emp_Mobile.Text);
                cmd.Parameters.AddWithValue("@EMPdesignation", Emp_Designation.Text);
                cmd.Parameters.AddWithValue("@EMPemail", Emp_Email.Text);
                cmd.Parameters.AddWithValue("@EBranchid", EMPBRANCH.Text);
                cmd.Parameters.AddWithValue("@EMPDOJ", EmpDateofJoining.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("EMP Information Saved Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void EmpUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("update Employee_TB set Employee_Name=@EMPname, Employee_Address=@EMPaddress, Employee_Mobile=@EMPmobileno, Employee_Designation=@EMPdesignation, Employee_Email=@EMPemail," + "Branch_ID=EBranchid, Date_of_Joining=@EMPDOJ  where Employee_ID=@EMPid", con);
                cmd.Parameters.AddWithValue("@EMPid", Emp_ID.Text);
                cmd.Parameters.AddWithValue("@EMPname", EMP_Name.Text);
                cmd.Parameters.AddWithValue("@EMPaddress", Emp_Address.Text);
                cmd.Parameters.AddWithValue("@EMPmobileno", Emp_Mobile.Text);
                cmd.Parameters.AddWithValue("@EMPdesignation", Emp_Designation.Text);
                cmd.Parameters.AddWithValue("@EMPemail", Emp_Email.Text);
                cmd.Parameters.AddWithValue("@EBranchid", EMPBRANCH.Text);
                cmd.Parameters.AddWithValue("@EMPDOJ", EmpDateofJoining.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void EmpDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("delete from Employee_TB where Employee_id=@EMPid", con);
                cmd.Parameters.AddWithValue("@EMPid", Emp_ID.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void EmpSearch_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataReader dr;
                DataTable dt = new DataTable();
                con.Open();
                cmd = new OleDbCommand("select [Employee_Name], [Employee_Address], [Employee_Mobile], [Employee_Designation], [Employee_Email], [Branch_ID], [Date_of_Joining] " +
                    "from Employee_TB where [Employee_id]=@EMPid", con);
                cmd.Parameters.AddWithValue("@EMPid", Emp_ID.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EMP_Name.Text = (dr["Employee_Name"].ToString());
                    Emp_Address.Text = (dr["Employee_Address"].ToString());
                    Emp_Mobile.Text = (dr["Employee_Mobile"].ToString());
                    Emp_Designation.Text = (dr["Employee_Designation"].ToString());
                    Emp_Email.Text = (dr["Employee_Email"].ToString());
                    EMPBRANCH.Text = (dr["Branch_ID"].ToString());
                    EmpDateofJoining.Text = (dr["Date_of_Joining"].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void EmpClear_Click(object sender, EventArgs e)
        {
            Emp_ID.Clear();
            EMP_Name.Clear();
            Emp_Address.Clear();
            Emp_Mobile.Clear();
            Emp_Designation.Clear();
            Emp_Email.Clear();
            EMPBRANCH.Clear();
            EmpDateofJoining.Clear();
        }

        private void Empclose_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }
    }
}
