using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Chit_Fund_Management_System
{
    public partial class f_login : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        OleDbDataReader dr;
        public static string admin;
        public f_login()
        {
            InitializeComponent();
        }

        private void LoginF_Load(object sender, EventArgs e)
        {

        }

        private void linklb_newuser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f_newuser f_Newuser = new f_newuser();
            f_Newuser.Show();
            this.Hide();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            tb_usernamelogin.Clear();
            tb_passwordlogin.Clear();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("SELECT * from LoginTB where User_name = '" + tb_usernamelogin.Text + "' and Password = '" + tb_passwordlogin.Text + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lb_user_type.Text = (dr["User_type"].ToString());
                    admin = lb_user_type.Text;
                    f_chit_fund_dash_board fund_Dash_Board = new f_chit_fund_dash_board();
                    fund_Dash_Board.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
