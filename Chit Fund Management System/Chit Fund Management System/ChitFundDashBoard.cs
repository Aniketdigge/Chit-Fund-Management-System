using System.Windows.Forms;

namespace Chit_Fund_Management_System
{
    public partial class f_chit_fund_dash_board : Form
    {
        public f_chit_fund_dash_board()
        {
            InitializeComponent();
        }

        private void ms_companyprofile_Click(object sender, System.EventArgs e)
        {
            CompanyProfile companyProfile = new CompanyProfile();
            companyProfile.Show();
            this.Hide();
        }

        private void branchProfileToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            f_branch_profile f_Branch_Profile = new f_branch_profile();
            f_Branch_Profile.Show();
            this.Hide();
        }

        private void lkb_back_to_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f_login f_Login = new f_login();
            f_Login.Show();
            this.Hide();
        }
    }
}
