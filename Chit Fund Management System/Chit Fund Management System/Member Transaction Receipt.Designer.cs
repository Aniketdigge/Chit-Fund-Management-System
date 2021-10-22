
namespace Chit_Fund_Management_System
{
    partial class Member_Transaction_Receipt
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
            this.crv_member_receipt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_member_receipt
            // 
            this.crv_member_receipt.ActiveViewIndex = -1;
            this.crv_member_receipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_member_receipt.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_member_receipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_member_receipt.Location = new System.Drawing.Point(0, 0);
            this.crv_member_receipt.Name = "crv_member_receipt";
            this.crv_member_receipt.Size = new System.Drawing.Size(1499, 689);
            this.crv_member_receipt.TabIndex = 0;
            // 
            // Member_Transaction_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 689);
            this.Controls.Add(this.crv_member_receipt);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Member_Transaction_Receipt";
            this.Text = "Member Transaction Receipt";
            this.Load += new System.EventHandler(this.Member_Transaction_Receipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_member_receipt;
    }
}