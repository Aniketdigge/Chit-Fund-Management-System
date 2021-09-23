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
                cmd = new OleDbCommand("update CompanyTB set Company_name=@companyname, Address=@address, City=@city, Owner=@owner, No_of_branches=@noofbranches where CIN_no=@cinno", con);
                cmd.Parameters.AddWithValue("@cinno", tb_cinno_company.Text);
                cmd.Parameters.AddWithValue("@companyname", tb_companyname.Text);
                cmd.Parameters.AddWithValue("@address", tb_address_company.Text);
                cmd.Parameters.AddWithValue("@city", tb_city_company.Text);
                cmd.Parameters.AddWithValue("@owner", tb_owner_company.Text);
                cmd.Parameters.AddWithValue("@noofbranches", tb_noofbranches.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_deletecompany_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("delete from CompanyTB where CIN_no=@cinno", con);
                cmd.Parameters.AddWithValue("@cinno", tb_cinno_company.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_searchcompany_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataReader dr;
                DataTable dt = new DataTable();
                con.Open();
                cmd = new OleDbCommand("select [Company_name], [Address], [City], [Owner], [No_of_branches] from CompanyTB where [CIN_no]=@cinno", con);
                cmd.Parameters.AddWithValue("@cinno", tb_cinno_company.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tb_companyname.Text = (dr["Company_name"].ToString());
                    tb_address_company.Text = (dr["Address"].ToString());
                    tb_city_company.Text = (dr["City"].ToString());
                    tb_owner_company.Text = (dr["Owner"].ToString());
                    tb_noofbranches.Text = (dr["No_of_branches"].ToString());
                }
                con.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_clearcompany_Click(object sender, EventArgs e)
        {
            tb_cinno_company.Clear();
            tb_companyname.Clear();
            tb_address_company.Clear();
            tb_city_company.Clear();
            tb_owner_company.Clear();
            tb_noofbranches.Clear();
        }

        private void bt_close_company_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }
    }
}
