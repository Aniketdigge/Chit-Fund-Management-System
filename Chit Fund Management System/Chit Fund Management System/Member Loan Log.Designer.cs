
namespace Chit_Fund_Management_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LogReport = new System.Windows.Forms.Button();
            this.agentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_mtl_installmentdate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.member_group_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.loan_installment = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.loanamount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chitamount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.member_name = new System.Windows.Forms.TextBox();
            this.member_id = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(1174, 86);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Loan";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.LogReport);
            this.groupBox1.Controls.Add(this.agentID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtp_mtl_installmentdate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.member_group_id);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.close);
            this.groupBox1.Controls.Add(this.loan_installment);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.loanamount);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.chitamount);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.member_name);
            this.groupBox1.Controls.Add(this.member_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 119);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1163, 531);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // LogReport
            // 
            this.LogReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogReport.Location = new System.Drawing.Point(432, 423);
            this.LogReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogReport.Name = "LogReport";
            this.LogReport.Size = new System.Drawing.Size(299, 45);
            this.LogReport.TabIndex = 29;
            this.LogReport.Text = "LOG REPORT";
            this.LogReport.UseVisualStyleBackColor = false;
            this.LogReport.Click += new System.EventHandler(this.LogReport_Click);
            // 
            // agentID
            // 
            this.agentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.agentID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.agentID.Location = new System.Drawing.Point(250, 211);
            this.agentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agentID.Multiline = true;
            this.agentID.Name = "agentID";
            this.agentID.Size = new System.Drawing.Size(270, 33);
            this.agentID.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 40);
            this.label3.TabIndex = 27;
            this.label3.Text = "Agent ID :";
            // 
            // dtp_mtl_installmentdate
            // 
            this.dtp_mtl_installmentdate.Location = new System.Drawing.Point(822, 210);
            this.dtp_mtl_installmentdate.Name = "dtp_mtl_installmentdate";
            this.dtp_mtl_installmentdate.Size = new System.Drawing.Size(270, 35);
            this.dtp_mtl_installmentdate.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(536, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(280, 40);
            this.label11.TabIndex = 25;
            this.label11.Text = "Date of Installment :";
            // 
            // member_group_id
            // 
            this.member_group_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.member_group_id.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.member_group_id.Location = new System.Drawing.Point(250, 154);
            this.member_group_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.member_group_id.Multiline = true;
            this.member_group_id.Name = "member_group_id";
            this.member_group_id.Size = new System.Drawing.Size(270, 33);
            this.member_group_id.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 40);
            this.label8.TabIndex = 23;
            this.label8.Text = "Group ID :";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(763, 337);
            this.close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(126, 45);
            this.close.TabIndex = 22;
            this.close.Text = "CLOSE";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // loan_installment
            // 
            this.loan_installment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loan_installment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loan_installment.Location = new System.Drawing.Point(822, 154);
            this.loan_installment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loan_installment.Multiline = true;
            this.loan_installment.Name = "loan_installment";
            this.loan_installment.Size = new System.Drawing.Size(270, 33);
            this.loan_installment.TabIndex = 20;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(605, 337);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(126, 45);
            this.clear.TabIndex = 21;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(596, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 40);
            this.label7.TabIndex = 19;
            this.label7.Text = " Loan Amount :";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(272, 337);
            this.add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(130, 45);
            this.add.TabIndex = 17;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(445, 337);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(126, 45);
            this.search.TabIndex = 20;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // loanamount
            // 
            this.loanamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loanamount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loanamount.Location = new System.Drawing.Point(822, 94);
            this.loanamount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loanamount.Multiline = true;
            this.loanamount.Name = "loanamount";
            this.loanamount.Size = new System.Drawing.Size(270, 33);
            this.loanamount.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(616, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 40);
            this.label9.TabIndex = 15;
            this.label9.Text = "Chit Amount :";
            // 
            // chitamount
            // 
            this.chitamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chitamount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chitamount.Location = new System.Drawing.Point(822, 34);
            this.chitamount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chitamount.Multiline = true;
            this.chitamount.Name = "chitamount";
            this.chitamount.Size = new System.Drawing.Size(270, 33);
            this.chitamount.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(563, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 40);
            this.label10.TabIndex = 13;
            this.label10.Text = "Loan Installment :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 40);
            this.label5.TabIndex = 7;
            this.label5.Text = "Member Name :";
            // 
            // member_name
            // 
            this.member_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.member_name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.member_name.Location = new System.Drawing.Point(250, 98);
            this.member_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.member_name.Multiline = true;
            this.member_name.Name = "member_name";
            this.member_name.Size = new System.Drawing.Size(270, 33);
            this.member_name.TabIndex = 4;
            // 
            // member_id
            // 
            this.member_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.member_id.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.member_id.Location = new System.Drawing.Point(250, 38);
            this.member_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.member_id.Multiline = true;
            this.member_id.Name = "member_id";
            this.member_id.Size = new System.Drawing.Size(270, 33);
            this.member_id.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Member ID :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1230, 677);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button LogReport;
        private System.Windows.Forms.TextBox agentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_mtl_installmentdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox member_group_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox loan_installment;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox loanamount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox chitamount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox member_name;
        private System.Windows.Forms.TextBox member_id;
        private System.Windows.Forms.Label label2;
    }
}