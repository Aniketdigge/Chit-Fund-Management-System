
namespace Chit_Fund_Management_System
{
    partial class Member_Invoice_Viewer
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
            this.crv_member_invoice = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_member_invoice
            // 
            this.crv_member_invoice.ActiveViewIndex = -1;
            this.crv_member_invoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_member_invoice.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_member_invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_member_invoice.Location = new System.Drawing.Point(0, 0);
            this.crv_member_invoice.Name = "crv_member_invoice";
            this.crv_member_invoice.Size = new System.Drawing.Size(1437, 690);
            this.crv_member_invoice.TabIndex = 0;
            // 
            // Member_Invoice_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 690);
            this.Controls.Add(this.crv_member_invoice);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Member_Invoice_Viewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Invoice";
            this.Load += new System.EventHandler(this.Member_Invoice_Viewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_member_invoice;
    }
}