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
    public partial class Loan_Installment_Log : Form
    {
        public Loan_Installment_Log()
        {
            InitializeComponent();
        }

        private void bt_view_report_Click(object sender, EventArgs e)
        {
            Loan_Installment_Log_Viewer loan_Installment_Log_Viewer = new Loan_Installment_Log_Viewer();
            loan_Installment_Log_Viewer.Show();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }
    }
}
