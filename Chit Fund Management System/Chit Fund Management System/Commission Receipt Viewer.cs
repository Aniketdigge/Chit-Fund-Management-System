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
    public partial class Commission_Receipt_Viewer : Form
    {
        public Commission_Receipt_Viewer()
        {
            InitializeComponent();
        }

        private void Commission_Receipt_Viewer_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument cryst = new ReportDocument();
                cryst.Load(@"F:\Chit-Fund-Management-System\Chit Fund Management System\Chit Fund Management System\Commission Receipt.rpt");
                TextObject paid_date = (TextObject)cryst.ReportDefinition.Sections["Section2"].ReportObjects["paid_date"];
                paid_date.Text = Agent_Payment.paid_date_ap;
                TextObject agent_id = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["agent_id"];
                agent_id.Text = Agent_Payment.agent_id_ap;
                TextObject agent_name = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["agent_name"];
                agent_name.Text = Agent_Payment.agent_name_ap;
                TextObject agent_mob = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["agent_mob_no"];
                agent_mob.Text = Agent_Payment.agent_mob_no_ap;
                TextObject group_id = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["group_id"];
                group_id.Text = Agent_Payment.group_id_ap;
                TextObject chit_amt = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["chit_amt"];
                chit_amt.Text = Agent_Payment.chit_amt_ap;
                TextObject commission_amt = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["commission_amt"];
                commission_amt.Text = Agent_Payment.commission_amt_ap;
                TextObject commission_tax = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["commission_tax"];
                commission_tax.Text = Agent_Payment.commission_tax_ap;
                TextObject net_commission = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["net_commission"];
                net_commission.Text = Agent_Payment.net_commission_ap;
                TextObject paid_amt = (TextObject)cryst.ReportDefinition.Sections["Section3"].ReportObjects["paid_amt"];
                paid_amt.Text = Agent_Payment.net_commission_ap;
                crv_commission_reeipt.ReportSource = cryst;
                crv_commission_reeipt.Refresh();
                cryst.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
