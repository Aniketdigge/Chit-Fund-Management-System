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
    public partial class Member_Transaction_Log : Form
    {
        public static string member_id = " ";
        public static string member_name = " ";
        public static string group_id = " ";
        public static string agent_id = " ";
        public static string chit_amt = " ";
        public static string loan_amt = " ";
        public static string transaction_mehtod = " ";
        public static string paid_amt = " ";
        public static string payment_date = " ";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public Member_Transaction_Log()
        {
            InitializeComponent();
        }

        private void tb_member_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_mtl_member_id.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid ID.");
                    tb_mtl_member_id.Text = tb_mtl_member_id.Text.Remove(tb_mtl_member_id.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_mtl_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into Member_Transaction_LogTB(Member_id, Member_name, Group_id, Amount_paid, Agent_id, Transaction_method, Transaction_date) values" +
                    "(@memberid, @membername, @groupid, @amountpaid, @agentid, @transactionmethod, @transactiondate)", con);
                cmd.Parameters.AddWithValue("@memberid", tb_mtl_member_id.Text);
                cmd.Parameters.AddWithValue("@membername", tb_mtl_member_name.Text);
                cmd.Parameters.AddWithValue("@groupid", tb_mtl_member_group_id.Text);
                cmd.Parameters.AddWithValue("@amountpaid", tb_mtl_amount_paid.Text);
                cmd.Parameters.AddWithValue("@agentid", tb_mtl_agent_id.Text);
                cmd.Parameters.AddWithValue("@transactionmethod", cb_mt_payment_method.Text);
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
                cmd = new OleDbCommand("select * from MemberTB where [Member_id]=@memberid", con);
                cmd.Parameters.AddWithValue("@memberid", tb_mtl_member_id.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tb_mtl_member_name.Text = (dr["Mname"].ToString());
                    tb_mtl_member_group_id.Text = (dr["gid"].ToString());
                    tb_mtl_agent_id.Text = (dr["aid"].ToString());
                    tb_mtl_chit_amount.Text = (dr["camt"].ToString());
                    tb_mtl_loan_amount.Text = (dr["lamt"].ToString());
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

        private void bt_member_transaction_receipt_Click(object sender, EventArgs e)
        {
            try
            {
                member_id = tb_mtl_member_id.Text;
                member_name = tb_mtl_member_name.Text;
                group_id = tb_mtl_member_group_id.Text;
                agent_id = tb_mtl_agent_id.Text;
                chit_amt = tb_mtl_chit_amount.Text;
                loan_amt = tb_mtl_loan_amount.Text;
                transaction_mehtod = cb_mt_payment_method.Text;
                paid_amt = tb_mtl_amount_paid.Text;
                payment_date = dtp_mtl_transaction_date.Value.ToString("d-M-yyyy");

                Member_Transaction_Receipt member_Transaction_Receipt = new Member_Transaction_Receipt();
                member_Transaction_Receipt.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_mtl_pay_Click(object sender, EventArgs e)
        {
            try
            {
                member_id = tb_mtl_member_id.Text;
                member_name = tb_mtl_member_name.Text;
                group_id = tb_mtl_member_group_id.Text;
                agent_id = tb_mtl_agent_id.Text;
                chit_amt = tb_mtl_chit_amount.Text;
                loan_amt = tb_mtl_loan_amount.Text;
                paid_amt = tb_mtl_amount_paid.Text;
                payment_date = dtp_mtl_transaction_date.Value.ToString("d-M-yyyy");

                Member_Payment member_Payment = new Member_Payment();
                member_Payment.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_mtl_member_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_mtl_member_name.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_mtl_member_name.Text = tb_mtl_member_name.Text.Remove(tb_mtl_member_name.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_mtl_member_group_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_mtl_member_group_id.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid ID.");
                    tb_mtl_member_group_id.Text = tb_mtl_member_group_id.Text.Remove(tb_mtl_member_group_id.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_mtl_agent_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_mtl_agent_id.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid ID.");
                    tb_mtl_agent_id.Text = tb_mtl_agent_id.Text.Remove(tb_mtl_agent_id.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_mtl_chit_amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_mtl_chit_amount.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid amount.");
                    tb_mtl_chit_amount.Text = tb_mtl_chit_amount.Text.Remove(tb_mtl_chit_amount.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_mtl_amount_paid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_mtl_amount_paid.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid amount.");
                    tb_mtl_amount_paid.Text = tb_mtl_amount_paid.Text.Remove(tb_mtl_amount_paid.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
