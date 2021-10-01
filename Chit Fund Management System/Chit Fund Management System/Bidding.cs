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
    public partial class Bidding : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public Bidding()
        {
            InitializeComponent();
        }

        private void bt_bidding_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into BiddingTB(Member_id, Member_name, Bidding_amount, Loan_amount, Group_id, Chit_amount, Bidding_date) values" +
                    "(@memberid, @membername, @biddingamount, @loanamount, @groupid, @chitamount, @biddingdate)", con);
                cmd.Parameters.AddWithValue("@memberid", tb_bidding_member_id.Text);
                cmd.Parameters.AddWithValue("@membername", tb_bidding_member_name.Text);
                cmd.Parameters.AddWithValue("@biddingamount", tb_bidding_amount.Text);
                cmd.Parameters.AddWithValue("@loanamount", tb_bidding_loan_amount.Text);
                cmd.Parameters.AddWithValue("@groupid", tb_bidding_member_group_id.Text);
                cmd.Parameters.AddWithValue("@chitamount", tb_bidding_chit_amount.Text);
                cmd.Parameters.AddWithValue("@biddingdate", dtp_bidding_date.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Bidding Done....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_bidding_search_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataReader dr;
                DataTable dt = new DataTable();
                con.Open();
                cmd = new OleDbCommand("select [Member_name], [Group_id], [Agent_id], [Chit_amount], [Loan_amount]" +
                    "from MemberTB where [Member_id]=@memberid", con);
                cmd.Parameters.AddWithValue("@memberid", tb_bidding_member_id.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tb_bidding_member_name.Text = (dr["Member_name"].ToString());
                    tb_bidding_member_group_id.Text = (dr["Group_id"].ToString());
                    tb_bidding_agent_id.Text = (dr["Agent_id"].ToString());
                    tb_bidding_chit_amount.Text = (dr["Chit_amount"].ToString());
                    tb_bidding_loan_amount.Text = (dr["Loan_amount"].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_bidding_clear_Click(object sender, EventArgs e)
        {
            tb_bidding_member_group_id.Clear();
            tb_bidding_member_id.Clear();
            tb_bidding_agent_id.Clear();
            tb_bidding_member_name.Clear();
            tb_bidding_loan_amount.Clear();
            tb_bidding_chit_amount.Clear();
            tb_bidding_amount.Clear();
            dtp_bidding_date.Value = DateTime.Today;
        }

        private void bt_bidding_close_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }
    }
}
