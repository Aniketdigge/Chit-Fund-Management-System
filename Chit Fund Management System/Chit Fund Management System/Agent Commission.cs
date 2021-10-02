﻿using System;
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
    public partial class Agent_Commission : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public Agent_Commission()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bt_commission_calculate_Click(object sender, EventArgs e)
        {
            int commission_amount;
            int chit_amount = int.Parse(tb_commission_chit_amount.Text);
            commission_amount = (2 / 100) * chit_amount;
            tb_commission_amount.Text = commission_amount.ToString();
        }

        private void bt_commission_save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into Agent_Commision_LogTB(Agent_id, Agent_name, Group_id, Chit_amount, Commission_amount, Date_of_received) values" +
                    "(@agentid, @agentname, @groupid, @chitamount, @commissionamount, @dateofreceived)", con);
                cmd.Parameters.AddWithValue("@agentid", tb_agent_id.Text);
                cmd.Parameters.AddWithValue("@agentname", tb_commission_agent_name.Text);
                cmd.Parameters.AddWithValue("@groupid", tb_commission_group_id.Text);
                cmd.Parameters.AddWithValue("@chitamount", tb_commission_chit_amount.Text);
                cmd.Parameters.AddWithValue("@commissionamount", tb_commission_amount.Text);
                cmd.Parameters.AddWithValue("@dateofreceived", dtp_commission_received_date.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_commission_search_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataReader dr;
                DataTable dt = new DataTable();
                con.Open();
                cmd = new OleDbCommand("select [Agent_name], [Agent_mobile_no]" +
                    "from AgentTB where [Agent_id]=@agentid", con);
                cmd.Parameters.AddWithValue("@agentid", tb_agent_id.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tb_commission_agent_name.Text = (dr["Agent_name"].ToString());
                    tb_commission_agent_mob.Text = (dr["Agent_mobile_no"].ToString());
                    
                }
                con.Close();
                con.Open();
                cmd = new OleDbCommand("select [Chit_amount]" +
                    "from MemberTB where [Group_id]=@groupid", con);
                cmd.Parameters.AddWithValue("@agentid", tb_commission_group_id.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tb_commission_chit_amount.Text = (dr["Chit_amount"].ToString());

                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_commission_clear_Click(object sender, EventArgs e)
        {
            tb_agent_id.Clear();
            tb_commission_agent_name.Clear();
            tb_commission_agent_mob.Clear();
            tb_commission_amount.Clear();
            tb_commission_group_id.Clear();
            tb_commission_chit_amount.Clear();
            dtp_commission_received_date.Value = DateTime.Today;
        }

        private void bt_commission_close_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }
    }
}
