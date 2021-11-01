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
    public partial class Add_Branch : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public Add_Branch()
        {
            InitializeComponent();
        }

        private void bt_add_add_branch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into BranchTB(Branch_address, Branch_city, Pincode, Branch_manager, Branch_email, Branch_phone_no, Head_office_addr, Date_of_registration) " +
                    "values(@branchaddress, @branchcity, @pincode, @branchmanager, @branchemail, @branchphoneno, @headofficeaddr, @dateofregistration)", con);
                cmd.Parameters.AddWithValue("@branchaddress", tb_branch_address_add_branch.Text);
                cmd.Parameters.AddWithValue("@branchcity", tb_branch_city_add_branch.Text);
                cmd.Parameters.AddWithValue("@pincode", tb_branch_pincode_add_branch.Text);
                cmd.Parameters.AddWithValue("@branchmanager", tb_branch_manager_add_branch.Text);
                cmd.Parameters.AddWithValue("@branchemail", tb_branch_email_add_branch.Text);
                cmd.Parameters.AddWithValue("@branchphoneno", tb_branch_phone_add_branch.Text);
                cmd.Parameters.AddWithValue("@headofficeaddr", tb_branch_headoffice_address_add_branch.Text);
                cmd.Parameters.AddWithValue("@dateofregistration", dtp_date_of_registration_add_branch.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_clear_add_branch_Click(object sender, EventArgs e)
        {
            tb_branch_address_add_branch.Clear();
            tb_branch_city_add_branch.Clear();
            tb_branch_pincode_add_branch.Clear();
            tb_branch_manager_add_branch.Clear();
            tb_branch_email_add_branch.Clear();
            tb_branch_phone_add_branch.Clear();
            tb_branch_headoffice_address_add_branch.Clear();
        }

        private void bt_close_add_branch_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }

        private void tb_branch_pincode_add_branch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_branch_pincode_add_branch.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid pincode.");
                    tb_branch_pincode_add_branch.Text = tb_branch_pincode_add_branch.Text.Remove(tb_branch_pincode_add_branch.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_branch_city_add_branch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_branch_city_add_branch.Text, "[^a-zA-Z]"))
                {
                    MessageBox.Show("Please enter valid city.");
                    tb_branch_city_add_branch.Text = tb_branch_city_add_branch.Text.Remove(tb_branch_city_add_branch.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_branch_manager_add_branch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_branch_manager_add_branch.Text, "[^A-Za-z ]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_branch_manager_add_branch.Text = tb_branch_manager_add_branch.Text.Remove(tb_branch_manager_add_branch.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_branch_phone_add_branch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_branch_phone_add_branch.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid phone number.");
                    tb_branch_phone_add_branch.Text = tb_branch_phone_add_branch.Text.Remove(tb_branch_phone_add_branch.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
