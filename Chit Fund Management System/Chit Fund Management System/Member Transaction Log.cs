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
    public partial class Member_Transaction_Log : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public Member_Transaction_Log()
        {
            InitializeComponent();
        }

        private void tb_member_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_mtl_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into Member_Transaction_LogTB(Member_id, Member_name, Group_id, Amount_paid, Agent_id, Transaction_date) values" +
                    "(@memberid, @membername, @groupid, @amountpaid, @agentid, @transactiondate)", con);
                cmd.Parameters.AddWithValue("@memberid", tb_mtl_member_id.Text);
                cmd.Parameters.AddWithValue("@membername", tb_mtl_member_name.Text);
                cmd.Parameters.AddWithValue("@groupid", tb_mtl_member_group_id.Text);
                cmd.Parameters.AddWithValue("@amountpaid", tb_mtl_amount_paid.Text);
                cmd.Parameters.AddWithValue("@agentid", tb_mtl_agent_id.Text);
                cmd.Parameters.AddWithValue("@transactiondate", dtp_mtl_transaction_date.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Log Entered Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_mtl_search_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataReader dr;
                DataTable dt = new DataTable();
                con.Open();
                cmd = new OleDbCommand("select [Member_name], [Group_id], [Agent_id], [Chit_amount], [Loan_amount]" +
                    "from MemberTB where [Member_id]=@memberid", con);
                cmd.Parameters.AddWithValue("@memberid", tb_mtl_member_id.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tb_mtl_member_name.Text = (dr["Member_name"].ToString());
                    tb_mtl_member_group_id.Text = (dr["Group_id"].ToString());
                    tb_mtl_agent_id.Text = (dr["Agent_id"].ToString());
                    tb_mtl_chit_amount.Text = (dr["Chit_amount"].ToString());
                    tb_mtl_loan_amount.Text = (dr["Loan_amount"].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_mtl_clear_Click(object sender, EventArgs e)
        {
            tb_mtl_member_id.Clear();
            tb_mtl_member_name.Clear();
            tb_mtl_member_group_id.Clear();
            tb_mtl_amount_paid.Clear();
            tb_mtl_agent_id.Clear();
            tb_mtl_chit_amount.Clear();
            tb_mtl_loan_amount.Clear();
        }

        private void bt_mtl_close_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member_Transaction_Log_Repo member_Transaction_Log_Repo = new Member_Transaction_Log_Repo();
            member_Transaction_Log_Repo.Show();
        }
    }
}
