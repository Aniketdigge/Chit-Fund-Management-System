
namespace Chit_Fund_Management_System
{
    partial class Commission_Receipt_Viewer
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
            this.crv_commission_reeipt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_commission_reeipt
            // 
            this.crv_commission_reeipt.ActiveViewIndex = -1;
            this.crv_commission_reeipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_commission_reeipt.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_commission_reeipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_commission_reeipt.Location = new System.Drawing.Point(0, 0);
            this.crv_commission_reeipt.Name = "crv_commission_reeipt";
            this.crv_commission_reeipt.Size = new System.Drawing.Size(1468, 689);
            this.crv_commission_reeipt.TabIndex = 0;
            this.crv_commission_reeipt.ToolPanelWidth = 175;
            // 
            // Commission_Receipt_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 689);
            this.Controls.Add(this.crv_commission_reeipt);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Commission_Receipt_Viewer";
            this.Text = "Commission Receipt";
            this.Load += new System.EventHandler(this.Commission_Receipt_Viewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crv_commission_reeipt;
    }
}