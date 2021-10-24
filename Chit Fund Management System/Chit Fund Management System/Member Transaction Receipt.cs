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
using CrystalDecisions.Shared;

namespace Chit_Fund_Management_System
{
    public partial class Member_Transaction_Receipt : Form
    {
        public Member_Transaction_Receipt()
        {
            InitializeComponent();
        }

        private void Member_Transaction_Receipt_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument cryst = new ReportDocument();
                cryst.Load(@"F:\Chit-Fund-Management-System\Chit Fund Management System\Chit Fund Management System\Member Receipt.rpt");
                TextObject payment_date = (TextObject)cryst.ReportDefinition.Sections["Section2"].ReportObjects["payment_date"];
                payment_date.Text = Member_Transaction_Log.payment_date;
                TextObject member_id = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["member_id"];
                member_id.Text = Member_Transaction_Log.member_id;
                TextObject member_name = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["member_name"];
                member_name.Text = Member_Transaction_Log.member_name;
                TextObject group_id = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["group_id"];
                group_id.Text = Member_Transaction_Log.group_id;
                TextObject agent_id = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["agent_id"];
                agent_id.Text = Member_Transaction_Log.agent_id;
                TextObject tr_method = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["tr_method"];
                tr_method.Text = Member_Transaction_Log.transaction_mehtod;
                TextObject chit_amt = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["chit_amt"];
                chit_amt.Text = Member_Transaction_Log.chit_amt;
                TextObject loan_amt = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["loan_amt"];
                loan_amt.Text = Member_Transaction_Log.loan_amt;
                TextObject paid_amt = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["paid_amt"];
                paid_amt.Text = Member_Transaction_Log.paid_amt;
                crv_member_receipt.ReportSource = cryst;
                crv_member_receipt.Refresh();
                cryst.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
