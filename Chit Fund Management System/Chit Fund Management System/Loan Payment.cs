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
    public partial class Loan_Payment : Form
    {
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
                cmd = new OleDbCommand("insert into Loan_ActivityTB(Member_id, Member_name, Loan_amount, Gross_amount, Intrest, Total_amount, Installment_date) values" +
                    "(@memberid, @membername, @loanamount, @grossamount, @intrest, @totalamount, @installmentdate)", con);
                cmd.Parameters.AddWithValue("@memberid", tb_loan_member_id.Text);
                cmd.Parameters.AddWithValue("@membername", tb_loan_member_name.Text);
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
                cmd = new OleDbCommand("select [Member_name], [Group_id], [Agent_id], [Chit_amount], [Loan_amount]" +
                    "from MemberTB where [Member_id]=@memberid", con);
                cmd.Parameters.AddWithValue("@memberid", tb_loan_member_id.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tb_loan_member_name.Text = (dr["Member_name"].ToString());
                    tb_loan_member_group_id.Text = (dr["Group_id"].ToString());
                    tb_loan_agent_id.Text = (dr["Agent_id"].ToString());
                    tb_loan_chit_amount.Text = (dr["Chit_amount"].ToString());
                    tb_loan_loan_amount.Text = (dr["Loan_amount"].ToString());
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
                cmd = new OleDbCommand("update MemberTB set Loan_amount=@loanamount where Member_id=@memberid", con);
                cmd.Parameters.AddWithValue("@memberid", tb_loan_member_id.Text);
                cmd.Parameters.AddWithValue("@loanamount", tb_loan_loan_amount.Text);
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
    }
}
