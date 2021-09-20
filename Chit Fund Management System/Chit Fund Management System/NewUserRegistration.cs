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
    public partial class NewUserRegistration : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ChitFundDB.accdb");
        OleDbCommand cmd;
        public NewUserRegistration()
        {
            InitializeComponent();
        }

        private void creatBT_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into LoginTB(User_name, Password, User_type) values(@username, @password, @usertype)", con);
                cmd.Parameters.AddWithValue("@username", tb_username.Text);
                cmd.Parameters.AddWithValue("@password", tb_password.Text);
                cmd.Parameters.AddWithValue("@usertype", tb_usertype.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User Created....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            tb_username.Clear();
            tb_password.Clear();
            tb_usertype.Clear();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            F_ligin f_Ligin = new F_ligin();
            f_Ligin.Show();
            this.Hide();
        }
    }
}
