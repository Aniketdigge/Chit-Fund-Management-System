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
    public partial class f_member_profile : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public f_member_profile()
        {
            InitializeComponent();
        }

        private void bt_member_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into MemberTB(Member_id, Member_name, Member_address, Member_mobile_no, Member_addhar_no, Agent_id, Chit_amount, Loan_amount, Group_id, Member_entry_date) values" +
                    "(@memberid, @membername, @memberaddress, @membermobileno, @memberaddharno, @agentid, @chitamount, @loanamount, @groupid, @memberentrydate)", con);
                cmd.Parameters.AddWithValue("@memberid", tb_member_id.Text);
                cmd.Parameters.AddWithValue("@membername", tb_member_name.Text);
                cmd.Parameters.AddWithValue("@memberaddress", tb_member_address.Text);
                cmd.Parameters.AddWithValue("@membermobileno", tb_member_mobile_no.Text);
                cmd.Parameters.AddWithValue("@memberaddharno", tb_member_addhar_no.Text);
                cmd.Parameters.AddWithValue("@agentid", tb_agent_id.Text);
                cmd.Parameters.AddWithValue("@chitamount", tb_chit_amount.Text);
                cmd.Parameters.AddWithValue("@loanamount", tb_loan_amount.Text);
                cmd.Parameters.AddWithValue("@groupid", tb_member_group_id.Text);
                cmd.Parameters.AddWithValue("@memberentrydate", dtp_member_entry_date.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Member Saved Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_member_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("update MemberTB set Member_name=@membername, Member_address=@memberaddress, Member_mobile_no=@membermobileno, Member_addhar_no=@memberaddharno, " +
                    "Agent_id=@agentid, Chit_amount=@chitamount, Loan_amount=@loanamount, Group_id=@groupid, Member_entry_date=@memberentrydate where Member_id=@memberid", con);
                cmd.Parameters.AddWithValue("@memberid", tb_member_id.Text);
                cmd.Parameters.AddWithValue("@membername", tb_member_name.Text);
                cmd.Parameters.AddWithValue("@membermobileno", tb_member_mobile_no.Text);
                cmd.Parameters.AddWithValue("@memberaddharno", tb_member_addhar_no.Text);
                cmd.Parameters.AddWithValue("@agentid", tb_agent_id.Text);
                cmd.Parameters.AddWithValue("@chitamount", tb_chit_amount.Text);
                cmd.Parameters.AddWithValue("@loanamount", tb_loan_amount.Text);
                cmd.Parameters.AddWithValue("@groupid", tb_member_group_id.Text);
                cmd.Parameters.AddWithValue("@memberentrydate", dtp_member_entry_date.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_member_delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("delete from MemberTB where Member_id=@memberid", con);
                cmd.Parameters.AddWithValue("@memberid", tb_member_id.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_member_search_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataReader dr;
                DataTable dt = new DataTable();
                con.Open();
                cmd = new OleDbCommand("select [Member_name], [Member_address], [Member_mobile_no], [Member_addhar_no], [Agent_id], [Chit_amount], [Loan_amount], [Group_id], [Member_entry_date]" +
                    "from MemberTB where [Member_id]=@memberid", con);
                cmd.Parameters.AddWithValue("@memberid", tb_member_id.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tb_member_name.Text = (dr["Member_name"].ToString());
                    tb_member_address.Text = (dr["Member_address"].ToString());
                    tb_member_mobile_no.Text = (dr["Member_mobile_no"].ToString());
                    tb_member_addhar_no.Text = (dr["Member_addhar_no"].ToString());
                    tb_agent_id.Text = (dr["Agent_id"].ToString());
                    tb_chit_amount.Text = (dr["Chit_amount"].ToString());
                    tb_loan_amount.Text = (dr["Loan_amount"].ToString());
                    tb_member_group_id.Text = (dr["Group_id"].ToString());
                    dtp_member_entry_date.Text = (dr["Member_entry_date"].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_member_clear_Click(object sender, EventArgs e)
        {
            tb_member_id.Clear();
            tb_member_name.Clear();
            tb_member_address.Clear();
            tb_member_mobile_no.Clear();
            tb_member_addhar_no.Clear();
            tb_agent_id.Clear();
            tb_chit_amount.Clear();
            tb_loan_amount.Clear();
            tb_member_group_id.Clear();
        }

        private void bt_member_close_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }
    }
}
