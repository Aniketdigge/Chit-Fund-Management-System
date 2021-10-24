
namespace Chit_Fund_Management_System
{
    partial class Member_Payment
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
            this.cb_mp_payment_type = new System.Windows.Forms.ComboBox();
            this.cb_mp_payment_method = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_mp_member_name = new System.Windows.Forms.Label();
            this.lb_mp_group_id = new System.Windows.Forms.Label();
            this.lb_mp_amount_paid = new System.Windows.Forms.Label();
            this.lb_mp_agent_id = new System.Windows.Forms.Label();
            this.lb_mp_payment_date = new System.Windows.Forms.Label();
            this.lb_mp_chit_amt = new System.Windows.Forms.Label();
            this.lb_mp_loan_amt = new System.Windows.Forms.Label();
            this.lb_mp_member_id = new System.Windows.Forms.Label();
            this.bt_mp_invoice = new System.Windows.Forms.Button();
            this.bt_mp_log_report = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_mp_close = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_mp_add = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(1475, 70);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Payment ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.cb_mp_payment_type);
            this.groupBox1.Controls.Add(this.cb_mp_payment_method);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lb_mp_member_name);
            this.groupBox1.Controls.Add(this.lb_mp_group_id);
            this.groupBox1.Controls.Add(this.lb_mp_amount_paid);
            this.groupBox1.Controls.Add(this.lb_mp_agent_id);
            this.groupBox1.Controls.Add(this.lb_mp_payment_date);
            this.groupBox1.Controls.Add(this.lb_mp_chit_amt);
            this.groupBox1.Controls.Add(this.lb_mp_loan_amt);
            this.groupBox1.Controls.Add(this.lb_mp_member_id);
            this.groupBox1.Controls.Add(this.bt_mp_invoice);
            this.groupBox1.Controls.Add(this.bt_mp_log_report);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.bt_mp_close);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.bt_mp_add);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(197, 120);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1103, 495);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // cb_mp_payment_type
            // 
            this.cb_mp_payment_type.FormattingEnabled = true;
            this.cb_mp_payment_type.Items.AddRange(new object[] {
            "Return",
            "Loan"});
            this.cb_mp_payment_type.Location = new System.Drawing.Point(811, 214);
            this.cb_mp_payment_type.Name = "cb_mp_payment_type";
            this.cb_mp_payment_type.Size = new System.Drawing.Size(155, 32);
            this.cb_mp_payment_type.TabIndex = 45;
            // 
            // cb_mp_payment_method
            // 
            this.cb_mp_payment_method.FormattingEnabled = true;
            this.cb_mp_payment_method.Items.AddRange(new object[] {
            "Cheque",
            "Cash",
            "NEFT"});
            this.cb_mp_payment_method.Location = new System.Drawing.Point(811, 158);
            this.cb_mp_payment_method.Name = "cb_mp_payment_method";
            this.cb_mp_payment_method.Size = new System.Drawing.Size(155, 32);
            this.cb_mp_payment_method.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(564, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 33);
            this.label6.TabIndex = 40;
            this.label6.Text = "Payment Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(563, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 33);
            this.label4.TabIndex = 39;
            this.label4.Text = "Payment Method :";
            // 
            // lb_mp_member_name
            // 
            this.lb_mp_member_name.AutoSize = true;
            this.lb_mp_member_name.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mp_member_name.Location = new System.Drawing.Point(287, 98);
            this.lb_mp_member_name.Name = "lb_mp_member_name";
            this.lb_mp_member_name.Size = new System.Drawing.Size(146, 33);
            this.lb_mp_member_name.TabIndex = 38;
            this.lb_mp_member_name.Text = "Member ID :";
            // 
            // lb_mp_group_id
            // 
            this.lb_mp_group_id.AutoSize = true;
            this.lb_mp_group_id.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mp_group_id.Location = new System.Drawing.Point(287, 158);
            this.lb_mp_group_id.Name = "lb_mp_group_id";
            this.lb_mp_group_id.Size = new System.Drawing.Size(146, 33);
            this.lb_mp_group_id.TabIndex = 37;
            this.lb_mp_group_id.Text = "Member ID :";
            // 
            // lb_mp_amount_paid
            // 
            this.lb_mp_amount_paid.AutoSize = true;
            this.lb_mp_amount_paid.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mp_amount_paid.Location = new System.Drawing.Point(805, 98);
            this.lb_mp_amount_paid.Name = "lb_mp_amount_paid";
            this.lb_mp_amount_paid.Size = new System.Drawing.Size(146, 33);
            this.lb_mp_amount_paid.TabIndex = 36;
            this.lb_mp_amount_paid.Text = "Member ID :";
            // 
            // lb_mp_agent_id
            // 
            this.lb_mp_agent_id.AutoSize = true;
            this.lb_mp_agent_id.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mp_agent_id.Location = new System.Drawing.Point(287, 211);
            this.lb_mp_agent_id.Name = "lb_mp_agent_id";
            this.lb_mp_agent_id.Size = new System.Drawing.Size(146, 33);
            this.lb_mp_agent_id.TabIndex = 35;
            this.lb_mp_agent_id.Text = "Member ID :";
            // 
            // lb_mp_payment_date
            // 
            this.lb_mp_payment_date.AutoSize = true;
            this.lb_mp_payment_date.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mp_payment_date.Location = new System.Drawing.Point(805, 264);
            this.lb_mp_payment_date.Name = "lb_mp_payment_date";
            this.lb_mp_payment_date.Size = new System.Drawing.Size(146, 33);
            this.lb_mp_payment_date.TabIndex = 34;
            this.lb_mp_payment_date.Text = "Member ID :";
            // 
            // lb_mp_chit_amt
            // 
            this.lb_mp_chit_amt.AutoSize = true;
            this.lb_mp_chit_amt.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mp_chit_amt.Location = new System.Drawing.Point(805, 38);
            this.lb_mp_chit_amt.Name = "lb_mp_chit_amt";
            this.lb_mp_chit_amt.Size = new System.Drawing.Size(146, 33);
            this.lb_mp_chit_amt.TabIndex = 33;
            this.lb_mp_chit_amt.Text = "Member ID :";
            // 
            // lb_mp_loan_amt
            // 
            this.lb_mp_loan_amt.AutoSize = true;
            this.lb_mp_loan_amt.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mp_loan_amt.Location = new System.Drawing.Point(287, 264);
            this.lb_mp_loan_amt.Name = "lb_mp_loan_amt";
            this.lb_mp_loan_amt.Size = new System.Drawing.Size(146, 33);
            this.lb_mp_loan_amt.TabIndex = 32;
            this.lb_mp_loan_amt.Text = "Member ID :";
            // 
            // lb_mp_member_id
            // 
            this.lb_mp_member_id.AutoSize = true;
            this.lb_mp_member_id.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mp_member_id.Location = new System.Drawing.Point(287, 38);
            this.lb_mp_member_id.Name = "lb_mp_member_id";
            this.lb_mp_member_id.Size = new System.Drawing.Size(146, 33);
            this.lb_mp_member_id.TabIndex = 31;
            this.lb_mp_member_id.Text = "Member ID :";
            // 
            // bt_mp_invoice
            // 
            this.bt_mp_invoice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_mp_invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mp_invoice.Location = new System.Drawing.Point(405, 358);
            this.bt_mp_invoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_mp_invoice.Name = "bt_mp_invoice";
            this.bt_mp_invoice.Size = new System.Drawing.Size(289, 45);
            this.bt_mp_invoice.TabIndex = 30;
            this.bt_mp_invoice.Text = "PRINT INVOICE";
            this.bt_mp_invoice.UseVisualStyleBackColor = false;
            this.bt_mp_invoice.Click += new System.EventHandler(this.bt_mp_invoice_Click);
            // 
            // bt_mp_log_report
            // 
            this.bt_mp_log_report.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_mp_log_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mp_log_report.Location = new System.Drawing.Point(405, 428);
            this.bt_mp_log_report.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_mp_log_report.Name = "bt_mp_log_report";
            this.bt_mp_log_report.Size = new System.Drawing.Size(289, 45);
            this.bt_mp_log_report.TabIndex = 29;
            this.bt_mp_log_report.Text = "LOG REPORT";
            this.bt_mp_log_report.UseVisualStyleBackColor = false;
            this.bt_mp_log_report.Click += new System.EventHandler(this.bt_mp_log_report_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 33);
            this.label3.TabIndex = 27;
            this.label3.Text = "Amount Paid :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(564, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 33);
            this.label11.TabIndex = 25;
            this.label11.Text = "Payment Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(84, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 33);
            this.label8.TabIndex = 23;
            this.label8.Text = "Group ID :";
            // 
            // bt_mp_close
            // 
            this.bt_mp_close.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_mp_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mp_close.Location = new System.Drawing.Point(711, 390);
            this.bt_mp_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_mp_close.Name = "bt_mp_close";
            this.bt_mp_close.Size = new System.Drawing.Size(126, 45);
            this.bt_mp_close.TabIndex = 22;
            this.bt_mp_close.Text = "CLOSE";
            this.bt_mp_close.UseVisualStyleBackColor = false;
            this.bt_mp_close.Click += new System.EventHandler(this.bt_mp_close_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 33);
            this.label7.TabIndex = 19;
            this.label7.Text = " Loan Amount :";
            // 
            // bt_mp_add
            // 
            this.bt_mp_add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_mp_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mp_add.Location = new System.Drawing.Point(254, 390);
            this.bt_mp_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_mp_add.Name = "bt_mp_add";
            this.bt_mp_add.Size = new System.Drawing.Size(130, 45);
            this.bt_mp_add.TabIndex = 17;
            this.bt_mp_add.Text = "ADD";
            this.bt_mp_add.UseVisualStyleBackColor = false;
            this.bt_mp_add.Click += new System.EventHandler(this.bt_mp_add_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(564, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 33);
            this.label9.TabIndex = 15;
            this.label9.Text = "Chit Amount :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(84, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 33);
            this.label10.TabIndex = 13;
            this.label10.Text = "Agent  ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Member Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Member ID :";
            // 
            // Member_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1498, 690);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Member_Payment";
            this.Text = "Member Payment";
            this.Load += new System.EventHandler(this.Member_Payment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_mp_invoice;
        private System.Windows.Forms.Button bt_mp_log_report;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_mp_close;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_mp_add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_mp_member_name;
        private System.Windows.Forms.Label lb_mp_group_id;
        private System.Windows.Forms.Label lb_mp_amount_paid;
        private System.Windows.Forms.Label lb_mp_agent_id;
        private System.Windows.Forms.Label lb_mp_payment_date;
        private System.Windows.Forms.Label lb_mp_chit_amt;
        private System.Windows.Forms.Label lb_mp_loan_amt;
        private System.Windows.Forms.Label lb_mp_member_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_mp_payment_type;
        private System.Windows.Forms.ComboBox cb_mp_payment_method;
    }
}