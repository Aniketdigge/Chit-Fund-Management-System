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
    public partial class Salary_Report : Form
    {
        public Salary_Report()
        {
            InitializeComponent();
        }

        private void bt_salary_report_Click(object sender, EventArgs e)
        {
            Salary_Payment_Repo salary_Payment_Repo = new Salary_Payment_Repo();
            salary_Payment_Repo.Show();
        }

        private void bt_salary_report_close_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }
    }
}
