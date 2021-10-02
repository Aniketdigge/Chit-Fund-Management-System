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
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into Member_Loan_LogTB(Member_id, Member_name, Group_id, Agent_id, Chit_Amount, Loan_Amount , Loan_Installment, Installment_date) values" +
                    "(@memberid, @membername, @groupid, @agentid, @chitamount, @loanamount, @loaninstallment, @dateofinstallment)", con);
                cmd.Parameters.AddWithValue("@memberid", member_id.Text);
                cmd.Parameters.AddWithValue("@membername", member_name.Text);
                cmd.Parameters.AddWithValue("@groupid", member_group_id.Text);
                cmd.Parameters.AddWithValue("@agentid", agentID.Text);
                cmd.Parameters.AddWithValue("@chitamount", chitamount.Text);
                cmd.Parameters.AddWithValue("@loanamount", loanamount.Text);
                cmd.Parameters.AddWithValue("@loaninstallment", loan_installment.Text);
                cmd.Parameters.AddWithValue("@dateofinstallment", dtp_mtl_installmentdate.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Log Entered Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataReader dr;
                DataTable dt = new DataTable();
                con.Open();
                cmd = new OleDbCommand("select [Member_name], [Group_id], [Agent_id], [Chit_amount], [Loan_amount]" +
                    "from MemberTB where [Member_id]=@memberid", con);
                cmd.Parameters.AddWithValue("@memberid", member_id.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    member_name.Text = (dr["Member_name"].ToString());
                    member_group_id.Text = (dr["Group_id"].ToString());
                    agentID.Text = (dr["Agent_id"].ToString());
                    chitamount.Text = (dr["Chit_amount"].ToString());
                    loanamount.Text = (dr["Loan_amount"].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            member_id.Clear();
            member_name.Clear();
            member_group_id.Clear();
            agentID.Clear();
            chitamount.Clear();
            loanamount.Clear();
            loan_installment.Clear();
        }

        private void close_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }

        private void LogReport_Click(object sender, EventArgs e)
        {
           // Member_Loan_Log_Repo member_Loan_Log_Repo = new Member_Loan_Log_Repo();
           // member_Loan_Log_Repo.Show(); //CHECK KAR HEY EKDA TE REPO GENERATE KAR..OKAY
        }
    }
}
