
namespace Chit_Fund_Management_System
{
    partial class Branch_Report_View
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
            this.crv_branch_report_view = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_branch_report_view
            // 
            this.crv_branch_report_view.ActiveViewIndex = -1;
            this.crv_branch_report_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_branch_report_view.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_branch_report_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_branch_report_view.Location = new System.Drawing.Point(0, 0);
            this.crv_branch_report_view.Name = "crv_branch_report_view";
            this.crv_branch_report_view.Size = new System.Drawing.Size(1465, 689);
            this.crv_branch_report_view.TabIndex = 0;
            this.crv_branch_report_view.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Branch_Report_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 689);
            this.Controls.Add(this.crv_branch_report_view);
            this.Name = "Branch_Report_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branch Report View";
            this.Load += new System.EventHandler(this.Branch_Report_View_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_branch_report_view;
    }
}