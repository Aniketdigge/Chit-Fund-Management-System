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
    public partial class Loan_Payment : Form
    {
        public static string member_id = " ";
        public static string member_name = " ";
        public static string payment_method = " ";
        public static string group_id = " ";
        public static string agent_id = " ";
        public static string chit_amt = " ";
        public static string loan_amt = " ";
        public static string gross_amt = " ";
        public static string intrest = " ";
        public static string total_amt = " ";
        public static string date_payment = " ";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public Loan_Payment()
        {
            InitializeComponent();
        }

        private void bt_calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double gross_amt, intrest, chit_amt, dif, total;
                chit_amt = double.Parse(tb_loan_loan_amount.Text);
                gross_amt = double.Parse(tb_loan_gross_amount.Text);
                intrest = 0.05 * chit_amt;
                dif = chit_amt - gross_amt;
                total = gross_amt + intrest;
                tb_loan_loan_amount.Text = dif.ToString();
                tb_loan_intrest.Text = intrest.ToString();
                tb_loan_total_amount.Text = total.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_loan_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into Loan_ActivityTB(Member_id, Member_name, Payment_method, Loan_amount, Gross_amount, Intrest, Total_amount, Installment_date) values" +
                    "(@memberid, @membername, @paymentmethod, @loanamount, @grossamount, @intrest, @totalamount, @installmentdate)", con);
                cmd.Parameters.AddWithValue("@memberid", tb_loan_member_id.Text);
                cmd.Parameters.AddWithValue("@membername", tb_loan_member_name.Text);
                cmd.Parameters.AddWithValue("@paymentmethod", cb_la_payment_method.Text);
                cmd.Parameters.AddWithValue("@loanamount", tb_loan_loan_amount.Text);
                cmd.Parameters.AddWithValue("@grossamount", tb_loan_gross_amount.Text);
                cmd.Parameters.AddWithValue("@intrest", tb_loan_intrest.Text);
                cmd.Parameters.AddWithValue("@totalamount", tb_loan_total_amount.Text);
                cmd.Parameters.AddWithValue("@installmentdate", dtp_loan_installment_date.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Log Entered Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_loan_search_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataReader dr;
                DataTable dt = new DataTable();
                con.Open();
                cmd = new OleDbCommand("select * from MemberTB where [Member_id]=@memberid", con);
                cmd.Parameters.AddWithValue("@memberid", tb_loan_member_id.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tb_loan_member_name.Text = (dr["Mname"].ToString());
                    tb_loan_member_group_id.Text = (dr["gid"].ToString());
                    tb_loan_agent_id.Text = (dr["aid"].ToString());
                    tb_loan_chit_amount.Text = (dr["camt"].ToString());
                    tb_loan_loan_amount.Text = (dr["lamt"].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("update MemberTB set lamt=@lamt where Member_id=@memberid", con);
                cmd.Parameters.AddWithValue("@memberid", tb_loan_member_id.Text);
                cmd.Parameters.AddWithValue("@lamt", tb_loan_loan_amount.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_loan_clear_Click(object sender, EventArgs e)
        {
            tb_loan_member_id.Clear();
            tb_loan_member_name.Clear();
            tb_loan_member_group_id.Clear();
            tb_loan_agent_id.Clear();
            tb_loan_chit_amount.Clear();
            tb_loan_loan_amount.Clear();
            tb_loan_gross_amount.Clear();
            tb_loan_intrest.Clear();
            tb_loan_total_amount.Clear();
        }

        private void bt_loan_close_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }

        private void bt_loan_receipt_Click(object sender, EventArgs e)
        {
            try
            {
                member_id = tb_loan_member_id.Text;
                member_name = tb_loan_member_name.Text;
                payment_method = cb_la_payment_method.Text;
                group_id = tb_loan_member_group_id.Text;
                agent_id = tb_loan_agent_id.Text;
                chit_amt = tb_loan_chit_amount.Text;
                loan_amt = tb_loan_loan_amount.Text;
                gross_amt = tb_loan_gross_amount.Text;
                intrest = tb_loan_gross_amount.Text;
                total_amt = tb_loan_total_amount.Text;
                date_payment = dtp_loan_installment_date.Value.ToString("d-M-yyyy");

                Loan_Receipt_Viewer loan_Receipt_Viewer = new Loan_Receipt_Viewer();
                loan_Receipt_Viewer.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_loan_log_Click(object sender, EventArgs e)
        {
            Loan_Installment_Log_Viewer loan_Installment_Log_Viewer = new Loan_Installment_Log_Viewer();
            loan_Installment_Log_Viewer.Show();
        }

        private void tb_loan_member_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_loan_member_id.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid id.");
                    tb_loan_member_id.Text = tb_loan_member_id.Text.Remove(tb_loan_member_id.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_loan_member_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_loan_member_name.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_loan_member_name.Text = tb_loan_member_name.Text.Remove(tb_loan_member_name.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_loan_member_group_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_loan_member_group_id.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid id.");
                    tb_loan_member_group_id.Text = tb_loan_member_group_id.Text.Remove(tb_loan_member_group_id.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_loan_agent_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_loan_agent_id.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid id.");
                    tb_loan_agent_id.Text = tb_loan_agent_id.Text.Remove(tb_loan_agent_id.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_loan_chit_amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_loan_chit_amount.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid amount.");
                    tb_loan_chit_amount.Text = tb_loan_chit_amount.Text.Remove(tb_loan_chit_amount.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_loan_loan_amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_loan_loan_amount.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid amount.");
                    tb_loan_loan_amount.Text = tb_loan_loan_amount.Text.Remove(tb_loan_loan_amount.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_loan_gross_amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_loan_gross_amount.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid amount.");
                    tb_loan_gross_amount.Text = tb_loan_gross_amount.Text.Remove(tb_loan_gross_amount.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_loan_intrest_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_loan_intrest.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid amount.");
                    tb_loan_intrest.Text = tb_loan_intrest.Text.Remove(tb_loan_intrest.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_loan_total_amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_loan_total_amount.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid amount.");
                    tb_loan_total_amount.Text = tb_loan_total_amount.Text.Remove(tb_loan_total_amount.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
