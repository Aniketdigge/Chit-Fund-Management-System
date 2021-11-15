using System.Windows.Forms;

namespace Chit_Fund_Management_System
{
    public partial class f_chit_fund_dash_board : Form
    {
        public f_chit_fund_dash_board()
        {
            InitializeComponent();
        }

        private void lkb_back_to_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f_login f_Login = new f_login();
            f_Login.Show();
            this.Hide();
        }

        private void branchReportToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Branch_Report_View branch_Report_View = new Branch_Report_View();
            branch_Report_View.Show();
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

        private void agentCommissionToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Agent_Commission agent_Commission = new Agent_Commission();
            agent_Commission.Show();
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

        private void addCompanyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Add_Company add_Company = new Add_Company();
            add_Company.Show();
            this.Hide();
        }

        private void editCompanyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Edit_Company edit_Company = new Edit_Company();
            edit_Company.Show();
            this.Hide();
        }

        private void addBranchToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Add_Branch add_Branch = new Add_Branch();
            add_Branch.Show();
            this.Hide();
        }

        private void editBranchToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Edit_Branch edit_Branch = new Edit_Branch();
            edit_Branch.Show();
            this.Hide();
        }

        private void addMemberToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Add_Member add_Member = new Add_Member();
            add_Member.Show();
            this.Hide();
        }

        private void editMemberToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Edit_Member edit_Member = new Edit_Member();
            edit_Member.Show();
            this.Hide();
        }

        private void addAgentToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Add_Agent add_Agent = new Add_Agent();
            add_Agent.Show();
            this.Hide();
        }

        private void editAgentToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Edit_Agent edit_Agent = new Edit_Agent();
            edit_Agent.Show();
            this.Hide();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Add_Employee add_Employee = new Add_Employee();
            add_Employee.Show();
            this.Hide();
        }

        private void editEmployeeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Edit_Employee edit_Employee = new Edit_Employee();
            edit_Employee.Show();
            this.Hide();
        }
    }
}
