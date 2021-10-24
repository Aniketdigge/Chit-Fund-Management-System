using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.OleDb;

namespace Chit_Fund_Management_System
{
    public partial class Agent_Payment : Form
    {
        public static string agent_id_ap = " ";
        public static string agent_name_ap = " ";
        public static string agent_mob_no_ap = " ";
        public static string group_id_ap = " ";
        public static string chit_amt_ap = " ";
        public static string commission_amt_ap = " ";
        public static string paid_date_ap = " ";
        public static string commission_tax_ap = " ";
        public static string net_commission_ap = " ";
        public static string payment_method = " ";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public Agent_Payment()
        {
            InitializeComponent();
        }

        private void bt_print_com_invoice_Click(object sender, EventArgs e)
        {
            try
            {
                agent_id_ap = lb_ap_agent_id.Text;
                agent_name_ap = lb_ap_agent_name.Text;
                agent_mob_no_ap = lb_ap_agent_mob.Text;
                group_id_ap = lb_ap_group_id.Text;
                chit_amt_ap = lb_ap_chit_amount.Text;
                commission_amt_ap = lb_ap_commission_amt.Text;
                paid_date_ap = lb_ap_date_of_payment.Text;
                commission_tax_ap = lb_ap_commission_tax.Text;
                net_commission_ap = lb_ap_net_commission.Text;
                payment_method = cb_payment_method.Text;

                Commission_Receipt_Viewer commission_Receipt_Viewer = new Commission_Receipt_Viewer();
                commission_Receipt_Viewer.Show();
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.ToString());
            }
        }

        private void bt_commission_save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into Agent_Commision_LogTB(Agent_id, Agent_name, Group_id, Chit_amount, Commission_amount, Commission_tax, Net_commission, Payment_menthod, Date_of_received) values" +
                    "(@agentid, @agentname, @groupid, @chitamount, @commissionamount, @commissiontax, @netcommission, @paymentmenthod, @dateofreceived)", con);
                cmd.Parameters.AddWithValue("@agentid", lb_ap_agent_id.Text);
                cmd.Parameters.AddWithValue("@agentname", lb_ap_agent_name.Text);
                cmd.Parameters.AddWithValue("@groupid", lb_ap_group_id.Text);
                cmd.Parameters.AddWithValue("@chitamount", lb_ap_chit_amount.Text);
                cmd.Parameters.AddWithValue("@commissionamount", lb_ap_commission_amt.Text);
                cmd.Parameters.AddWithValue("@commissiontax", lb_ap_commission_tax.Text);
                cmd.Parameters.AddWithValue("@netcommission", lb_ap_net_commission.Text);
                cmd.Parameters.AddWithValue("@paymentmenthod", cb_payment_method.Text);
                cmd.Parameters.AddWithValue("@dateofreceived", lb_ap_date_of_payment.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_commission_close_Click(object sender, EventArgs e)
        {
            Agent_Commission agent_Commission = new Agent_Commission();
            agent_Commission.Show();
            this.Hide();
        }

        private void Agent_Payment_Load(object sender, EventArgs e)
        {
            lb_ap_agent_id.Text = Agent_Commission.agent_id;
            lb_ap_agent_name.Text = Agent_Commission.agent_name;
            lb_ap_agent_mob.Text = Agent_Commission.agent_mob_no;
            lb_ap_group_id.Text = Agent_Commission.group_id;
            lb_ap_chit_amount.Text = Agent_Commission.chit_amt;
            lb_ap_commission_amt.Text = Agent_Commission.commission_amt;
            lb_ap_date_of_payment.Text = Agent_Commission.paid_date;

            double com_amt, net_com, com_tax;
            com_amt = double.Parse(lb_ap_commission_amt.Text);
            com_tax = 0.05 * com_amt;
            net_com = com_amt - com_tax;
            lb_ap_commission_tax.Text = com_tax.ToString();
            lb_ap_net_commission.Text = net_com.ToString();
        }
    }
}
