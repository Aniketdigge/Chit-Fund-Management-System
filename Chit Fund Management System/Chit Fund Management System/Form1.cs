using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chit_Fund_Management_System
{
    public partial class f_login : Form
    {
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
    }
}
