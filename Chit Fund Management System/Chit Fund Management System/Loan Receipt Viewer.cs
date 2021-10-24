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
    public partial class Loan_Receipt_Viewer : Form
    {
        public Loan_Receipt_Viewer()
        {
            InitializeComponent();
        }

        private void Loan_Receipt_Viewer_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument cryst = new ReportDocument();
                cryst.Load(@"F:\Chit-Fund-Management-System\Chit Fund Management System\Chit Fund Management System\Loan Receipt.rpt");
                TextObject date_of_payment = (TextObject)cryst.ReportDefinition.Sections["Section2"].ReportObjects["date_of_payment"];
                date_of_payment.Text = Loan_Payment.date_payment;
                TextObject member_id = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["member_id"];
                member_id.Text = Loan_Payment.member_id;
                TextObject member_name = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["member_name"];
                member_name.Text = Loan_Payment.member_name;
                TextObject pyament_method = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["pyament_method"];
                pyament_method.Text = Loan_Payment.payment_method;
                TextObject group_id = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["group_id"];
                group_id.Text = Loan_Payment.group_id;
                TextObject agent_id = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["agent_id"];
                agent_id.Text = Loan_Payment.agent_id;
                TextObject chit_amount = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["chit_amount"];
                chit_amount.Text = Loan_Payment.chit_amt;
                TextObject loan_amount = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["loan_amount"];
                loan_amount.Text = Loan_Payment.loan_amt;
                TextObject gross_amount = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["gross_amount"];
                gross_amount.Text = Loan_Payment.gross_amt;
                TextObject intrest = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["intrest"];
                intrest.Text = Loan_Payment.intrest;
                TextObject total_amount = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["total_amount"];
                total_amount.Text = Loan_Payment.total_amt;
                TextObject amount_payble = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["amount_payble"];
                amount_payble.Text = Loan_Payment.total_amt;
                crv_loan_receipt_viewer.ReportSource = cryst;
                crv_loan_receipt_viewer.Refresh();
                cryst.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
