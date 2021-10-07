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
    public partial class Agent_Commission_Log : Form
    {
        public Agent_Commission_Log()
        {
            InitializeComponent();
        }

        private void bt_commission_log_Click(object sender, EventArgs e)
        {
            Agent_Commission_Log_Repo agent_Commission_Log_Repo = new Agent_Commission_Log_Repo();
            agent_Commission_Log_Repo.Show();
        }

        private void bt_commission_log_close_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }
    }
}
