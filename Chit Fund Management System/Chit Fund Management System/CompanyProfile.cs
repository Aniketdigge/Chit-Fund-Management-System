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
    public partial class CompanyProfile : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public CompanyProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into CompanyTB(CIN_no, Company_name, Address, City, Owner, No_of_branches) values(@cinno, @companyname, @address, @city, @owner, @noofbranches)", con);
                cmd.Parameters.AddWithValue("@cinno", tb_cinno_company.Text);
                cmd.Parameters.AddWithValue("@companyname", tb_companyname.Text);
                cmd.Parameters.AddWithValue("@address", tb_address_company.Text);
                cmd.Parameters.AddWithValue("@city", tb_city_company.Text);
                cmd.Parameters.AddWithValue("@owner", tb_owner_company.Text);
                cmd.Parameters.AddWithValue("@noofbranches", tb_noofbranches.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Company Created Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_updatecompany_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into CompanyTB(CIN_no, Company_name, Address, City, Owner, No_of_branches) values(@cinno, @companyname, @address, @city, @owner, @noofbranches)", con);
                cmd.Parameters.AddWithValue("@cinno", tb_cinno_company.Text);
                cmd.Parameters.AddWithValue("@companyname", tb_companyname.Text);
                cmd.Parameters.AddWithValue("@address", tb_address_company.Text);
                cmd.Parameters.AddWithValue("@city", tb_city_company.Text);
                cmd.Parameters.AddWithValue("@owner", tb_owner_company.Text);
                cmd.Parameters.AddWithValue("@noofbranches", tb_noofbranches.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Company Created Successfully....");
            }
        }
    }
}
