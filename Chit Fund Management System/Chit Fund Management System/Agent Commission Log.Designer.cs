
namespace Chit_Fund_Management_System
{
    partial class Agent_Commission_Log
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
            this.bt_commission_log_close = new System.Windows.Forms.Button();
            this.bt_commission_log = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 70);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agent Commission Log";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.bt_commission_log_close);
            this.groupBox1.Controls.Add(this.bt_commission_log);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(181, 133);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(436, 266);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // bt_commission_log_close
            // 
            this.bt_commission_log_close.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_commission_log_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_commission_log_close.Location = new System.Drawing.Point(151, 151);
            this.bt_commission_log_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_commission_log_close.Name = "bt_commission_log_close";
            this.bt_commission_log_close.Size = new System.Drawing.Size(126, 45);
            this.bt_commission_log_close.TabIndex = 22;
            this.bt_commission_log_close.Text = "CLOSE";
            this.bt_commission_log_close.UseVisualStyleBackColor = false;
            this.bt_commission_log_close.Click += new System.EventHandler(this.bt_commission_log_close_Click);
            // 
            // bt_commission_log
            // 
            this.bt_commission_log.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_commission_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_commission_log.Location = new System.Drawing.Point(100, 84);
            this.bt_commission_log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_commission_log.Name = "bt_commission_log";
            this.bt_commission_log.Size = new System.Drawing.Size(231, 45);
            this.bt_commission_log.TabIndex = 17;
            this.bt_commission_log.Text = "COMMISSION LOG";
            this.bt_commission_log.UseVisualStyleBackColor = false;
            this.bt_commission_log.Click += new System.EventHandler(this.bt_commission_log_Click);
            // 
            // Agent_Commission_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(852, 464);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Agent_Commission_Log";
            this.Text = "Agent Commission Log";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_commission_log_close;
        private System.Windows.Forms.Button bt_commission_log;
    }
}