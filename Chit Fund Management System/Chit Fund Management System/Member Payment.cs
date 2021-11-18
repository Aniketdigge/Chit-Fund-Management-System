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
    public partial class Member_Payment : Form
    {
        public static string member_id_mp = " ";
        public static string member_name_mp = " ";
        public static string group_id_mp = " ";
        public static string agent_id_mp = " ";
        public static string chit_amt_mp = " ";
        public static string loan_amt_mp = " ";
        public static string paid_amt_mp = " ";
        public static string payment_method_mp = " ";
        public static string payment_type_mp = " ";
        public static string payment_date_mp = " ";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public Member_Payment()
        {
            InitializeComponent();
        }

        private void bt_mp_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into Member_paymentTB(Member_id, Member_name, Group_id, Amount_paid, Agent_id, Payment_method, Payment_type, Transaction_date) values" +
                    "(@memberid, @membername, @groupid, @amountpaid, @agentid, @paymentmethod, @paymenttype, @transactiondate)", con);
                cmd.Parameters.AddWithValue("@memberid", lb_mp_member_id.Text);
                cmd.Parameters.AddWithValue("@membername", lb_mp_member_name.Text);
                cmd.Parameters.AddWithValue("@groupid", lb_mp_group_id.Text);
                cmd.Parameters.AddWithValue("@amountpaid", lb_mp_amount_paid.Text);
                cmd.Parameters.AddWithValue("@agentid", lb_mp_agent_id.Text);
                cmd.Parameters.AddWithValue("@paymentmethod", cb_mp_payment_method.Text);
                cmd.Parameters.AddWithValue("@paymenttype", cb_mp_payment_type.Text);
                cmd.Parameters.AddWithValue("@transactiondate", lb_mp_payment_date.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                if (cb_mp_payment_type.Text == "Loan")
                {
                    int Mid = int.Parse(lb_mp_member_id.Text);
                    con.Open();
                    cmd = new OleDbCommand("update MemberTB set Lamt='"+ lb_mp_amount_paid.Text + "' where Member_id="+ Mid, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Log Entered Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_mp_invoice_Click(object sender, EventArgs e)
        {
            try
            {
                member_id_mp = lb_mp_member_id.Text;
                member_name_mp = lb_mp_member_name.Text;
                group_id_mp = lb_mp_group_id.Text;
                agent_id_mp = lb_mp_agent_id.Text;
                chit_amt_mp = lb_mp_chit_amt.Text;
                loan_amt_mp = lb_mp_loan_amt.Text;
                payment_method_mp = cb_mp_payment_method.Text;
                payment_type_mp = cb_mp_payment_type.Text;
                paid_amt_mp = lb_mp_amount_paid.Text;
                payment_date_mp = lb_mp_payment_date.Text;

                Member_Invoice_Viewer member_Invoice = new Member_Invoice_Viewer();
                member_Invoice.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_mp_log_report_Click(object sender, EventArgs e)
        {
            Member_Payment_Log member_Payment_Log = new Member_Payment_Log();
            member_Payment_Log.Show();
        }

        private void bt_mp_close_Click(object sender, EventArgs e)
        {
            Member_Transaction_Log member_Transaction_Log = new Member_Transaction_Log();
            member_Transaction_Log.Show();
            this.Hide();
        }

        private void Member_Payment_Load(object sender, EventArgs e)
        {
            lb_mp_member_id.Text = Member_Transaction_Log.member_id;
            lb_mp_member_name.Text = Member_Transaction_Log.member_name;
            lb_mp_group_id.Text = Member_Transaction_Log.group_id;
            lb_mp_agent_id.Text = Member_Transaction_Log.agent_id;
            lb_mp_loan_amt.Text = Member_Transaction_Log.loan_amt;
            lb_mp_chit_amt.Text = Member_Transaction_Log.chit_amt;
            lb_mp_amount_paid.Text = Member_Transaction_Log.paid_amt;
            lb_mp_payment_date.Text = Member_Transaction_Log.payment_date;
        }
    }
}
