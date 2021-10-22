
namespace Chit_Fund_Management_System
{
    partial class Loan_Installment_Log_Viewer
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
            this.crv_loan_installment_log_viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_loan_installment_log_viewer
            // 
            this.crv_loan_installment_log_viewer.ActiveViewIndex = -1;
            this.crv_loan_installment_log_viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_loan_installment_log_viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_loan_installment_log_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_loan_installment_log_viewer.Location = new System.Drawing.Point(0, 0);
            this.crv_loan_installment_log_viewer.Name = "crv_loan_installment_log_viewer";
            this.crv_loan_installment_log_viewer.Size = new System.Drawing.Size(1497, 690);
            this.crv_loan_installment_log_viewer.TabIndex = 0;
            // 
            // Loan_Installment_Log_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 690);
            this.Controls.Add(this.crv_loan_installment_log_viewer);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Loan_Installment_Log_Viewer";
            this.Text = "Loan Installment Log Viewer";
            this.Load += new System.EventHandler(this.Loan_Installment_Log_Viewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_loan_installment_log_viewer;
    }
}