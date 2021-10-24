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
    public partial class Member_Invoice_Viewer : Form
    {
        public Member_Invoice_Viewer()
        {
            InitializeComponent();
        }

        private void Member_Invoice_Viewer_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument cryst = new ReportDocument();
                cryst.Load(@"F:\Chit-Fund-Management-System\Chit Fund Management System\Chit Fund Management System\Member Invoice.rpt");
                TextObject paid_date = (TextObject)cryst.ReportDefinition.Sections["Section2"].ReportObjects["paid_date"];
                paid_date.Text = Member_Payment.payment_date_mp;
                TextObject member_id = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["member_id"];
                member_id.Text = Member_Payment.member_id_mp;
                TextObject member_name = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["member_name"];
                member_name.Text = Member_Payment.member_name_mp;
                TextObject group_id = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["group_id"];
                group_id.Text = Member_Payment.group_id_mp;
                TextObject agent_id = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["agent_id"];
                agent_id.Text = Member_Payment.agent_id_mp;
                TextObject payment_type = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["payment_type"];
                payment_type.Text = Member_Payment.payment_type_mp;
                TextObject payment_method = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["payment_method"];
                payment_method.Text = Member_Payment.payment_method_mp;
                TextObject chit_amt = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["chit_amt"];
                chit_amt.Text = Member_Payment.chit_amt_mp;
                TextObject loan_amt = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["loan_amt"];
                loan_amt.Text = Member_Payment.loan_amt_mp;
                TextObject paid_amt = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["paid_amt"];
                paid_amt.Text = Member_Payment.paid_amt_mp;
                crv_member_invoice.ReportSource = cryst;
                crv_member_invoice.Refresh();
                cryst.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
