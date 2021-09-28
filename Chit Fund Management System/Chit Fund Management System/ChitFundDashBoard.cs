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

        private void memberProfileToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            f_member_profile f_Member_Profile = new f_member_profile();
            f_Member_Profile.Show();
            this.Hide();
        }

        private void agentProfileToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Agent_Profile agent_Profile = new Agent_Profile();
            agent_Profile.Show();
            this.Hide();
        }

        private void branchReportToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Branch_Repo branch_Repo = new Branch_Repo();
            branch_Repo.Show();
            this.Hide();
        }
    }
}
