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
    public partial class Bidding_Log : Form
    {
        public Bidding_Log()
        {
            InitializeComponent();
        }

        private void bt_bidding_add_Click(object sender, EventArgs e)
        {
            Bidding_Log_Repo bidding_Log_Repo = new Bidding_Log_Repo();
            bidding_Log_Repo.Show();
        }

        private void bt_bidding_close_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }
    }
}
