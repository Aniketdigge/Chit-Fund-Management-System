
namespace Chit_Fund_Management_System
{
    partial class Agent_Commission_Log_Repo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crv_agent_commission_log_report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_agent_commission_log_report
            // 
            this.crv_agent_commission_log_report.ActiveViewIndex = -1;
            this.crv_agent_commission_log_report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_agent_commission_log_report.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_agent_commission_log_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_agent_commission_log_report.Location = new System.Drawing.Point(0, 0);
            this.crv_agent_commission_log_report.Name = "crv_agent_commission_log_report";
            this.crv_agent_commission_log_report.Size = new System.Drawing.Size(1469, 689);
            this.crv_agent_commission_log_report.TabIndex = 0;
            // 
            // Agent_Commission_Log_Repo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 689);
            this.Controls.Add(this.crv_agent_commission_log_report);
            this.Name = "Agent_Commission_Log_Repo";
            this.Text = "Agent Commission Log Report";
            this.Load += new System.EventHandler(this.Agent_Commission_Log_Repo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_agent_commission_log_report;
    }
}