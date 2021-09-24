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
    public partial class f_branch_profile : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public f_branch_profile()
        {
            InitializeComponent();
        }

        private void bt_add_branch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into BranchTB(Branch_id, Branch_address, Branch_city, Branch_manager) values(@branchid, @branchaddress, @branchcity, @branchmanager)", con);
                cmd.Parameters.AddWithValue("@branchid", tb_branch_id.Text);
                cmd.Parameters.AddWithValue("@branchaddress", tb_branch_address.Text);
                cmd.Parameters.AddWithValue("@branchcity", tb_branch_city.Text);
                cmd.Parameters.AddWithValue("@branchmanager", tb_branch_manager.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Branch Saved Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_update_branch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("update BranchTB set Branch_address=@branchaddress, Branch_city=@branchcity, Branch_manager=@branchmanager where Branch_id=@branchid", con);
                cmd.Parameters.AddWithValue("@branchid", tb_branch_id.Text);
                cmd.Parameters.AddWithValue("@branchaddress", tb_branch_address.Text);
                cmd.Parameters.AddWithValue("@branchcity", tb_branch_city.Text);
                cmd.Parameters.AddWithValue("@branchmanager", tb_branch_manager.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_delete_branch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("delete from BranchTB where Branch_id=@branchid", con);
                cmd.Parameters.AddWithValue("@branchid", tb_branch_id.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_search_branch_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataReader dr;
                DataTable dt = new DataTable();
                con.Open();
                cmd = new OleDbCommand("select [Branch_address], [Branch_city], [Branch_manager] from BranchTB where [Branch_id]=@branchid", con);
                cmd.Parameters.AddWithValue("@cinno", tb_branch_id.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tb_branch_address.Text = (dr["Branch_address"].ToString());
                    tb_branch_city.Text = (dr["Branch_city"].ToString());
                    tb_branch_manager.Text = (dr["Branch_manager"].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_clear_branch_Click(object sender, EventArgs e)
        {
            tb_branch_id.Clear();
            tb_branch_address.Clear();
            tb_branch_city.Clear();
            tb_branch_manager.Clear();
        }

        private void bt_close_branch_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }
    }
}
