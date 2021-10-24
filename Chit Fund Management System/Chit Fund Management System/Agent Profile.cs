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
    public partial class Agent_Profile : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public Agent_Profile()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bt_agent_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into AgentTB(Agent_id, Agent_name, Agent_mobile_no, Agent_address, Agent_email, Agent_addhar_no, Agent_joining_date) values" +
                    "(@agentid, @agentname, @agentmobileno, @agentaddress, @agentemail, @agentaddharno, @agentjoiningdate)", con);
                cmd.Parameters.AddWithValue("@agentid", tb_agent_id.Text);
                cmd.Parameters.AddWithValue("@agentname", tb_agent_name.Text);
                cmd.Parameters.AddWithValue("@agentmobileno", tb_agent_mobile_no.Text);
                cmd.Parameters.AddWithValue("@agentaddress", tb_agent_address.Text);
                cmd.Parameters.AddWithValue("@agentemail", tb_agent_email.Text);
                cmd.Parameters.AddWithValue("@agentaddharno", tb_agent_addhar_no.Text);
                cmd.Parameters.AddWithValue("@agentjoiningdate", dtp_agent_joining_date.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_agent_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("update AgentTB set Agent_name=@agentname, Agent_mobile_no=@agentmobileno, Agent_address=@agentaddress, Agent_email=@agentemail, " +
                    "Agent_addhar_no=@agentaddharno, Agent_joining_date=@agentjoiningdate where Agent_id=@agentid", con);
                cmd.Parameters.AddWithValue("@agentid", tb_agent_id.Text);
                cmd.Parameters.AddWithValue("@agentname", tb_agent_name.Text);
                cmd.Parameters.AddWithValue("@agentmobileno", tb_agent_mobile_no.Text);
                cmd.Parameters.AddWithValue("@agentaddress", tb_agent_address.Text);
                cmd.Parameters.AddWithValue("@agentemail", tb_agent_email.Text);
                cmd.Parameters.AddWithValue("@agentaddharno", tb_agent_addhar_no.Text);
                cmd.Parameters.AddWithValue("@agentjoiningdate", dtp_agent_joining_date.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_agent_delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("delete from AgentTB where Agent_id=@agentid", con);
                cmd.Parameters.AddWithValue("@agentid", tb_agent_id.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_agent_search_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataReader dr;
                DataTable dt = new DataTable();
                con.Open();
                cmd = new OleDbCommand("select [Agent_name], [Agent_mobile_no], [Agent_address], [Agent_email], [Agent_addhar_no], [Agent_joining_date]" +
                    "from AgentTB where [Agent_id]=@agentid", con);
                cmd.Parameters.AddWithValue("@agentid", tb_agent_id.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tb_agent_name.Text = (dr["Agent_name"].ToString());
                    tb_agent_mobile_no.Text = (dr["Agent_mobile_no"].ToString());
                    tb_agent_address.Text = (dr["Agent_address"].ToString());
                    tb_agent_email.Text = (dr["Agent_email"].ToString());
                    tb_agent_addhar_no.Text = (dr["Agent_addhar_no"].ToString());
                    dtp_agent_joining_date.Text = (dr["Agent_joining_date"].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_agent_clear_Click(object sender, EventArgs e)
        {
            tb_agent_id.Clear();
            tb_agent_name.Clear();
            tb_agent_mobile_no.Clear();
            tb_agent_address.Clear();
            tb_agent_email.Clear();
            tb_agent_addhar_no.Clear();
        }

        private void bt_agent_close_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }
    }
}
