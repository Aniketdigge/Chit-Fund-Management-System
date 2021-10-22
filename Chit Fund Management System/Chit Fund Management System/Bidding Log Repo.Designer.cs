
namespace Chit_Fund_Management_System
{
    partial class Bidding_Log_Repo
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
            this.crv_bidding_log_repo = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_bidding_log_repo
            // 
            this.crv_bidding_log_repo.ActiveViewIndex = -1;
            this.crv_bidding_log_repo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_bidding_log_repo.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_bidding_log_repo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_bidding_log_repo.Location = new System.Drawing.Point(0, 0);
            this.crv_bidding_log_repo.Name = "crv_bidding_log_repo";
            this.crv_bidding_log_repo.Size = new System.Drawing.Size(1467, 689);
            this.crv_bidding_log_repo.TabIndex = 0;
            // 
            // Bidding_Log_Repo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 689);
            this.Controls.Add(this.crv_bidding_log_repo);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Bidding_Log_Repo";
            this.Text = "Bidding Log Report";
            this.Load += new System.EventHandler(this.Bidding_Log_Repo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_bidding_log_repo;
    }
}