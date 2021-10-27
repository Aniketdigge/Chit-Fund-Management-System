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
    public partial class Add_Company : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public Add_Company()
        {
            InitializeComponent();
        }

        private void bt_add_add_company_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into CompanyTB(CIN_no, Company_name, Address, City, Owner, No_of_branches) values(@cinno, @companyname, @address, @city, @owner, @noofbranches)", con);
                cmd.Parameters.AddWithValue("@cinno", tb_cinno_add_company.Text);
                cmd.Parameters.AddWithValue("@companyname", tb_companyname_add_company.Text);
                cmd.Parameters.AddWithValue("@address", tb_address_add_company.Text);
                cmd.Parameters.AddWithValue("@city", tb_city_add_company.Text);
                cmd.Parameters.AddWithValue("@owner", tb_owner_add_company.Text);
                cmd.Parameters.AddWithValue("@noofbranches", tb_noofbranches_add_company.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Company Saved Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_cinno_add_company_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(tb_cinno_add_company.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only number.");
                tb_cinno_add_company.Text = tb_cinno_add_company.Text.Remove(tb_cinno_add_company.Text.Length - 1);
            }
        }

        private void bt_close_add_company_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }

        private void tb_owner_add_company_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_noofbranches_add_company_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb_cinno_add_company.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only number.");
                tb_cinno_add_company.Text = tb_cinno_add_company.Text.Remove(tb_cinno_add_company.Text.Length - 1);
            }
        }
    }
}
