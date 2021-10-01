
namespace Chit_Fund_Management_System
{
    partial class Bidding_Log
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
            this.bt_bidding_add = new System.Windows.Forms.Button();
            this.bt_bidding_close = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(793, 70);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bidding Log";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.bt_bidding_close);
            this.groupBox1.Controls.Add(this.bt_bidding_add);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(190, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(436, 266);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // bt_bidding_add
            // 
            this.bt_bidding_add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_bidding_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bidding_add.Location = new System.Drawing.Point(123, 86);
            this.bt_bidding_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_bidding_add.Name = "bt_bidding_add";
            this.bt_bidding_add.Size = new System.Drawing.Size(191, 45);
            this.bt_bidding_add.TabIndex = 17;
            this.bt_bidding_add.Text = "BIDDING LOG";
            this.bt_bidding_add.UseVisualStyleBackColor = false;
            this.bt_bidding_add.Click += new System.EventHandler(this.bt_bidding_add_Click);
            // 
            // bt_bidding_close
            // 
            this.bt_bidding_close.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_bidding_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bidding_close.Location = new System.Drawing.Point(152, 158);
            this.bt_bidding_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_bidding_close.Name = "bt_bidding_close";
            this.bt_bidding_close.Size = new System.Drawing.Size(126, 45);
            this.bt_bidding_close.TabIndex = 22;
            this.bt_bidding_close.Text = "CLOSE";
            this.bt_bidding_close.UseVisualStyleBackColor = false;
            this.bt_bidding_close.Click += new System.EventHandler(this.bt_bidding_close_Click);
            // 
            // Bidding_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(817, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Bidding_Log";
            this.Text = "Bidding Log";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_bidding_add;
        private System.Windows.Forms.Button bt_bidding_close;
    }
}