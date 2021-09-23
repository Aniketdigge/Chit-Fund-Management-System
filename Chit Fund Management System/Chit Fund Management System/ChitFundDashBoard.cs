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
    }
}
