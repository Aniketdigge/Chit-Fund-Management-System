using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace Chit_Fund_Management_System
{
    public partial class f_newuser : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public f_newuser()
        {
            InitializeComponent();
        }

        private void creatBT_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into LoginTB(User_name, Password, User_type) values(@username, @password, @usertype)", con);;
                cmd.Parameters.AddWithValue("@username", tb_usernamenew.Text);
                cmd.Parameters.AddWithValue("@password", tb_passwordnew.Text);
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

        private void bt_clear_new_user_Click(object sender, EventArgs e)
        {
            tb_usernamenew.Clear();
            tb_passwordnew.Clear();
            tb_usertype.Clear();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            f_login f_Ligin = new f_login();
            f_Ligin.Show();
            this.Hide();
        }

        private void bt_search_new_user_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataReader dr;
                DataTable dt = new DataTable();
                con.Open();
                cmd = new OleDbCommand("select * from LoginTB where [User_name]=@User_name", con);
                cmd.Parameters.AddWithValue("@User_name", tb_usernamenew.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tb_passwordnew.Text = (dr["Password"].ToString());
                    tb_usertype.Text = (dr["User_type"].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_del_new_user_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("delete from LoginTB where User_name=@User_name", con);
                cmd.Parameters.AddWithValue("@User_name", tb_usernamenew.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Successfully....");

                tb_usernamenew.Clear();
                tb_passwordnew.Clear();
                tb_usertype.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
