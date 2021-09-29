
namespace Chit_Fund_Management_System
{
    partial class Branch_Repo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_branch_report_close = new System.Windows.Forms.Button();
            this.bt_branch_report_print = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 70);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch Report";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.bt_branch_report_close);
            this.groupBox1.Controls.Add(this.bt_branch_report_print);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(232, 130);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(544, 283);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report";
            // 
            // bt_branch_report_close
            // 
            this.bt_branch_report_close.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_branch_report_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_branch_report_close.Location = new System.Drawing.Point(198, 170);
            this.bt_branch_report_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_branch_report_close.Name = "bt_branch_report_close";
            this.bt_branch_report_close.Size = new System.Drawing.Size(126, 45);
            this.bt_branch_report_close.TabIndex = 16;
            this.bt_branch_report_close.Text = "CLOSE";
            this.bt_branch_report_close.UseVisualStyleBackColor = false;
            this.bt_branch_report_close.Click += new System.EventHandler(this.bt_branch_report_close_Click);
            // 
            // bt_branch_report_print
            // 
            this.bt_branch_report_print.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_branch_report_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_branch_report_print.Location = new System.Drawing.Point(171, 63);
            this.bt_branch_report_print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_branch_report_print.Name = "bt_branch_report_print";
            this.bt_branch_report_print.Size = new System.Drawing.Size(184, 63);
            this.bt_branch_report_print.TabIndex = 11;
            this.bt_branch_report_print.Text = "VIEW REPORT";
            this.bt_branch_report_print.UseVisualStyleBackColor = false;
            this.bt_branch_report_print.Click += new System.EventHandler(this.bt_branch_report_print_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Branch_Repo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1007, 525);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Branch_Repo";
            this.Text = "Branch Report";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_branch_report_close;
        private System.Windows.Forms.Button bt_branch_report_print;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}