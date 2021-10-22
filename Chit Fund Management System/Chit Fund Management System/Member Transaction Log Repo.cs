using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.OleDb;

namespace Chit_Fund_Management_System
{
    public partial class Member_Transaction_Log_Repo : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public Member_Transaction_Log_Repo()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Member_Transaction_Log_Repo_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"F:\Chit-Fund-Management-System\Chit Fund Management System\Chit Fund Management System\Member Transaction Log Report.rpt");
            crv_member_transaction_log_report.ReportSource = cryRpt;
            crv_member_transaction_log_report.Refresh();
            cryRpt.Refresh();
        }

        /*private void bt_mtlr_search_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Member_Transaction_LogTB where Member_id='" + tb_mtlr_member_id.Text + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
                DataSet datar = new DataSet();
                da.Fill(datar, "Member_Transaction_LogTB");

                Member_Transaction_Log_Report myrepo = new Member_Transaction_Log_Report();
                myrepo.SetDataSource(datar);
                crv_member_transaction_log_report.ReportSource = myrepo;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }*/
    }
}
