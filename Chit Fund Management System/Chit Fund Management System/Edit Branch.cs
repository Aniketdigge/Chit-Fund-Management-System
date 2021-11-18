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
    public partial class Edit_Branch : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public Edit_Branch()
        {
            InitializeComponent();
        }

        private void bt_update_edit_branch_Click(object sender, EventArgs e)
        {
            try
            {
                int Bid = int.Parse(tb_branch_id_edit_branch.Text);
                con.Open();
                cmd = new OleDbCommand("update BranchTB set Branch_address='"+ tb_branch_address_edit_branch.Text + "', " +
                    "Branch_city='"+ tb_branch_city_edit_branch.Text + "', Pincode='"+ tb_branch_pincode_edit_branch.Text + "', " +
                    "Branch_manager='"+ tb_branch_manager_edit_branch.Text + "', Branch_email='"+ tb_branch_email_edit_branch.Text + "', " +
                    "Branch_phone_no='"+ tb_branch_phone_edit_branch.Text + "', Head_office_addr='"+ tb_branch_headoffice_address_edit_branch.Text + "', " +
                    "Date_of_registration='"+ dtp_date_of_registration_edit_branch.Text + "' where Branch_id="+ Bid, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_search_edit_branch_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataReader dr;
                DataTable dt = new DataTable();
                con.Open();
                cmd = new OleDbCommand("select [Branch_address], [Branch_city], [Pincode], [Branch_manager], [Branch_email], [Branch_phone_no], [Head_office_addr], [Date_of_registration]" +
                    " from BranchTB where [Branch_id]=@branchid", con);
                cmd.Parameters.AddWithValue("@cinno", tb_branch_id_edit_branch.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tb_branch_address_edit_branch.Text = (dr["Branch_address"].ToString());
                    tb_branch_city_edit_branch.Text = (dr["Branch_city"].ToString());
                    tb_branch_pincode_edit_branch.Text = (dr["Pincode"].ToString());
                    tb_branch_manager_edit_branch.Text = (dr["Branch_manager"].ToString());
                    tb_branch_email_edit_branch.Text = (dr["Branch_email"].ToString());
                    tb_branch_phone_edit_branch.Text = (dr["Branch_phone_no"].ToString());
                    tb_branch_headoffice_address_edit_branch.Text = (dr["Head_office_addr"].ToString());
                    dtp_date_of_registration_edit_branch.Text = (dr["Date_of_registration"].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_clear_edit_branch_Click(object sender, EventArgs e)
        {
            tb_branch_id_edit_branch.Clear();
            tb_branch_address_edit_branch.Clear();
            tb_branch_city_edit_branch.Clear();
            tb_branch_pincode_edit_branch.Clear();
            tb_branch_manager_edit_branch.Clear();
            tb_branch_email_edit_branch.Clear();
            tb_branch_phone_edit_branch.Clear();
            tb_branch_headoffice_address_edit_branch.Clear();
        }

        private void bt_close_edit_branch_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }

        private void bt_del_edit_branch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("delete from BranchTB where Branch_id=@branchid", con);
                cmd.Parameters.AddWithValue("@branchid", tb_branch_id_edit_branch.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete successfully....");

                tb_branch_id_edit_branch.Clear();
                tb_branch_address_edit_branch.Clear();
                tb_branch_city_edit_branch.Clear();
                tb_branch_pincode_edit_branch.Clear();
                tb_branch_manager_edit_branch.Clear();
                tb_branch_email_edit_branch.Clear();
                tb_branch_phone_edit_branch.Clear();
                tb_branch_headoffice_address_edit_branch.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_branch_id_edit_branch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_branch_id_edit_branch.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid branch id.");
                    tb_branch_id_edit_branch.Text = tb_branch_id_edit_branch.Text.Remove(tb_branch_id_edit_branch.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_branch_pincode_edit_branch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_branch_pincode_edit_branch.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid pincode.");
                    tb_branch_pincode_edit_branch.Text = tb_branch_pincode_edit_branch.Text.Remove(tb_branch_pincode_edit_branch.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_branch_city_edit_branch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_branch_city_edit_branch.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid city.");
                    tb_branch_city_edit_branch.Text = tb_branch_city_edit_branch.Text.Remove(tb_branch_city_edit_branch.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_branch_manager_edit_branch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_branch_manager_edit_branch.Text, "[^A-Za-z ]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_branch_manager_edit_branch.Text = tb_branch_manager_edit_branch.Text.Remove(tb_branch_manager_edit_branch.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_branch_phone_edit_branch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_branch_phone_edit_branch.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid phone number.");
                    tb_branch_phone_edit_branch.Text = tb_branch_phone_edit_branch.Text.Remove(tb_branch_phone_edit_branch.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
