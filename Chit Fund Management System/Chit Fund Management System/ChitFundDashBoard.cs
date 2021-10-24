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

        private void employeeProfileToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            f_employee_profile f_Employee_Profile = new f_employee_profile();
            f_Employee_Profile.Show();
            this.Hide();
        }

        private void memberTransactionLogToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Member_Transaction_Log member_Transaction_Log = new Member_Transaction_Log();
            member_Transaction_Log.Show();
            this.Hide();
        }

        private void biddingToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Bidding bidding = new Bidding();
            bidding.Show();
            this.Hide();
        }

        private void biddingLogToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Bidding_Log bidding_Log = new Bidding_Log();
            bidding_Log.Show();
            this.Hide();
        }

        private void agentCommissionToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Agent_Commission agent_Commission = new Agent_Commission();
            agent_Commission.Show();
            this.Hide();
        }

        private void agentPaymentLogToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Agent_Commission_Log agent_Commission_Log = new Agent_Commission_Log();
            agent_Commission_Log.Show();
            this.Hide();
        }

        private void employeeAttendanceToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Employee_Attendence employee_Attendence = new Employee_Attendence();
            employee_Attendence.Show();
            this.Hide();
        }

        private void employeeSalarySlipToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Employee_Salary_Slip employee_Salary_Slip = new Employee_Salary_Slip();
            employee_Salary_Slip.Show();
            this.Hide();
        }

        private void employeePaymentLogToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Salary_Report salary_Report = new Salary_Report();
            salary_Report.Show();
            this.Hide();
        }

        private void employeeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void loanToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Loan_Payment loan_Payment = new Loan_Payment();
            loan_Payment.Show();
            this.Hide();
        }

        private void loanInstallmentLogToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            
        }

        private void agentPaymentToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void f_chit_fund_dash_board_Load(object sender, System.EventArgs e)
        {
            if(f_login.admin == "Admin")
            {
                companyToolStripMenuItem.Enabled = true;
                branchToolStripMenuItem.Enabled = true;
                employeeToolStripMenuItem.Enabled = true;
            }
            else
            {
                companyToolStripMenuItem.Enabled = false;
                branchToolStripMenuItem.Enabled = false;
                employeeToolStripMenuItem.Enabled = false;
            }
        }
    }
}
