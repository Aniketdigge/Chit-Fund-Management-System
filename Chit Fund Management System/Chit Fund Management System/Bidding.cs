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
                cmd = new OleDbCommand("select * from MemberTB where [Member_id]=@memberid", con);
                cmd.Parameters.AddWithValue("@memberid", tb_bidding_member_id.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tb_bidding_member_name.Text = (dr["Mname"].ToString());
                    tb_bidding_member_group_id.Text = (dr["gid"].ToString());
                    tb_bidding_agent_id.Text = (dr["aid"].ToString());
                    tb_bidding_chit_amount.Text = (dr["camt"].ToString());
                    tb_bidding_loan_amount.Text = (dr["lamt"].ToString());
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

        private void bt_bidding_log_Click(object sender, EventArgs e)
        {
            Bidding_Log_Repo bidding_Log_Repo = new Bidding_Log_Repo();
            bidding_Log_Repo.Show();
        }

        private void tb_bidding_member_group_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_bidding_member_group_id.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid id.");
                    tb_bidding_member_group_id.Text = tb_bidding_member_group_id.Text.Remove(tb_bidding_member_group_id.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_bidding_agent_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_bidding_agent_id.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid id.");
                    tb_bidding_agent_id.Text = tb_bidding_agent_id.Text.Remove(tb_bidding_agent_id.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_bidding_chit_amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_bidding_chit_amount.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid amount.");
                    tb_bidding_chit_amount.Text = tb_bidding_chit_amount.Text.Remove(tb_bidding_chit_amount.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_bidding_loan_amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_bidding_loan_amount.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid amount.");
                    tb_bidding_loan_amount.Text = tb_bidding_loan_amount.Text.Remove(tb_bidding_loan_amount.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_bidding_member_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_bidding_member_id.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid id.");
                    tb_bidding_member_id.Text = tb_bidding_member_id.Text.Remove(tb_bidding_member_id.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_bidding_member_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_bidding_member_name.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_bidding_member_name.Text = tb_bidding_member_name.Text.Remove(tb_bidding_member_name.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_bidding_amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_bidding_amount.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid amount.");
                    tb_bidding_amount.Text = tb_bidding_amount.Text.Remove(tb_bidding_amount.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
