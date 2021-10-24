
namespace Chit_Fund_Management_System
{
    partial class Member_Payment_Log
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
            this.crv_member_payment_log = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_member_payment_log
            // 
            this.crv_member_payment_log.ActiveViewIndex = -1;
            this.crv_member_payment_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_member_payment_log.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_member_payment_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_member_payment_log.Location = new System.Drawing.Point(0, 0);
            this.crv_member_payment_log.Name = "crv_member_payment_log";
            this.crv_member_payment_log.Size = new System.Drawing.Size(1499, 690);
            this.crv_member_payment_log.TabIndex = 0;
            // 
            // Member_Payment_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 690);
            this.Controls.Add(this.crv_member_payment_log);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Member_Payment_Log";
            this.Text = "Member Payment Log";
            this.Load += new System.EventHandler(this.Member_Payment_Log_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_member_payment_log;
    }
}