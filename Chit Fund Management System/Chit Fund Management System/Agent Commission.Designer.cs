
namespace Chit_Fund_Management_System
{
    partial class Agent_Commission
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_commission_receipt = new System.Windows.Forms.Button();
            this.tb_commission_amount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_commission_chit_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_commission_received_date = new System.Windows.Forms.DateTimePicker();
            this.bt_commission_close = new System.Windows.Forms.Button();
            this.bt_commission_clear = new System.Windows.Forms.Button();
            this.bt_commission_search = new System.Windows.Forms.Button();
            this.bt_commission_save = new System.Windows.Forms.Button();
            this.bt_commission_calculate = new System.Windows.Forms.Button();
            this.tb_commission_agent_mob = new System.Windows.Forms.TextBox();
            this.tb_commission_agent_name = new System.Windows.Forms.TextBox();
            this.tb_commission_group_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_agent_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1455, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agent Commission";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.bt_commission_receipt);
            this.groupBox2.Controls.Add(this.tb_commission_amount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_commission_chit_amount);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtp_commission_received_date);
            this.groupBox2.Controls.Add(this.bt_commission_close);
            this.groupBox2.Controls.Add(this.bt_commission_clear);
            this.groupBox2.Controls.Add(this.bt_commission_search);
            this.groupBox2.Controls.Add(this.bt_commission_save);
            this.groupBox2.Controls.Add(this.bt_commission_calculate);
            this.groupBox2.Controls.Add(this.tb_commission_agent_mob);
            this.groupBox2.Controls.Add(this.tb_commission_agent_name);
            this.groupBox2.Controls.Add(this.tb_commission_group_id);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_agent_id);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(193, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1054, 485);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // bt_commission_receipt
            // 
            this.bt_commission_receipt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_commission_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_commission_receipt.Location = new System.Drawing.Point(491, 425);
            this.bt_commission_receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_commission_receipt.Name = "bt_commission_receipt";
            this.bt_commission_receipt.Size = new System.Drawing.Size(152, 45);
            this.bt_commission_receipt.TabIndex = 29;
            this.bt_commission_receipt.Text = "RECEIPT";
            this.bt_commission_receipt.UseVisualStyleBackColor = false;
            this.bt_commission_receipt.Click += new System.EventHandler(this.bt_commission_receipt_Click);
            // 
            // tb_commission_amount
            // 
            this.tb_commission_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_commission_amount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_commission_amount.Location = new System.Drawing.Point(581, 237);
            this.tb_commission_amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_commission_amount.Multiline = true;
            this.tb_commission_amount.Name = "tb_commission_amount";
            this.tb_commission_amount.Size = new System.Drawing.Size(270, 33);
            this.tb_commission_amount.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 33);
            this.label5.TabIndex = 27;
            this.label5.Text = "Commission Amount :";
            // 
            // tb_commission_chit_amount
            // 
            this.tb_commission_chit_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_commission_chit_amount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_commission_chit_amount.Location = new System.Drawing.Point(744, 107);
            this.tb_commission_chit_amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_commission_chit_amount.Multiline = true;
            this.tb_commission_chit_amount.Name = "tb_commission_chit_amount";
            this.tb_commission_chit_amount.Size = new System.Drawing.Size(270, 33);
            this.tb_commission_chit_amount.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(527, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 33);
            this.label3.TabIndex = 25;
            this.label3.Text = "Chit Amount :";
            // 
            // dtp_commission_received_date
            // 
            this.dtp_commission_received_date.Location = new System.Drawing.Point(744, 162);
            this.dtp_commission_received_date.Name = "dtp_commission_received_date";
            this.dtp_commission_received_date.Size = new System.Drawing.Size(270, 30);
            this.dtp_commission_received_date.TabIndex = 24;
            // 
            // bt_commission_close
            // 
            this.bt_commission_close.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_commission_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_commission_close.Location = new System.Drawing.Point(744, 361);
            this.bt_commission_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_commission_close.Name = "bt_commission_close";
            this.bt_commission_close.Size = new System.Drawing.Size(126, 45);
            this.bt_commission_close.TabIndex = 23;
            this.bt_commission_close.Text = "CLOSE";
            this.bt_commission_close.UseVisualStyleBackColor = false;
            this.bt_commission_close.Click += new System.EventHandler(this.bt_commission_close_Click);
            // 
            // bt_commission_clear
            // 
            this.bt_commission_clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_commission_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_commission_clear.Location = new System.Drawing.Point(581, 361);
            this.bt_commission_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_commission_clear.Name = "bt_commission_clear";
            this.bt_commission_clear.Size = new System.Drawing.Size(126, 45);
            this.bt_commission_clear.TabIndex = 22;
            this.bt_commission_clear.Text = "CLEAR";
            this.bt_commission_clear.UseVisualStyleBackColor = false;
            this.bt_commission_clear.Click += new System.EventHandler(this.bt_commission_clear_Click);
            // 
            // bt_commission_search
            // 
            this.bt_commission_search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_commission_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_commission_search.Location = new System.Drawing.Point(423, 361);
            this.bt_commission_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_commission_search.Name = "bt_commission_search";
            this.bt_commission_search.Size = new System.Drawing.Size(126, 45);
            this.bt_commission_search.TabIndex = 21;
            this.bt_commission_search.Text = "SEARCH";
            this.bt_commission_search.UseVisualStyleBackColor = false;
            this.bt_commission_search.Click += new System.EventHandler(this.bt_commission_search_Click);
            // 
            // bt_commission_save
            // 
            this.bt_commission_save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_commission_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_commission_save.Location = new System.Drawing.Point(260, 361);
            this.bt_commission_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_commission_save.Name = "bt_commission_save";
            this.bt_commission_save.Size = new System.Drawing.Size(126, 45);
            this.bt_commission_save.TabIndex = 19;
            this.bt_commission_save.Text = "SAVE";
            this.bt_commission_save.UseVisualStyleBackColor = false;
            this.bt_commission_save.Click += new System.EventHandler(this.bt_commission_save_Click);
            // 
            // bt_commission_calculate
            // 
            this.bt_commission_calculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_commission_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_commission_calculate.Location = new System.Drawing.Point(491, 289);
            this.bt_commission_calculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_commission_calculate.Name = "bt_commission_calculate";
            this.bt_commission_calculate.Size = new System.Drawing.Size(152, 45);
            this.bt_commission_calculate.TabIndex = 18;
            this.bt_commission_calculate.Text = "CALCULATE";
            this.bt_commission_calculate.UseVisualStyleBackColor = false;
            this.bt_commission_calculate.Click += new System.EventHandler(this.bt_commission_calculate_Click);
            // 
            // tb_commission_agent_mob
            // 
            this.tb_commission_agent_mob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_commission_agent_mob.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_commission_agent_mob.Location = new System.Drawing.Point(230, 161);
            this.tb_commission_agent_mob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_commission_agent_mob.Multiline = true;
            this.tb_commission_agent_mob.Name = "tb_commission_agent_mob";
            this.tb_commission_agent_mob.Size = new System.Drawing.Size(270, 33);
            this.tb_commission_agent_mob.TabIndex = 15;
            // 
            // tb_commission_agent_name
            // 
            this.tb_commission_agent_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_commission_agent_name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_commission_agent_name.Location = new System.Drawing.Point(230, 111);
            this.tb_commission_agent_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_commission_agent_name.Multiline = true;
            this.tb_commission_agent_name.Name = "tb_commission_agent_name";
            this.tb_commission_agent_name.Size = new System.Drawing.Size(270, 33);
            this.tb_commission_agent_name.TabIndex = 14;
            // 
            // tb_commission_group_id
            // 
            this.tb_commission_group_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_commission_group_id.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_commission_group_id.Location = new System.Drawing.Point(744, 50);
            this.tb_commission_group_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_commission_group_id.Multiline = true;
            this.tb_commission_group_id.Name = "tb_commission_group_id";
            this.tb_commission_group_id.Size = new System.Drawing.Size(270, 33);
            this.tb_commission_group_id.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(527, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 33);
            this.label8.TabIndex = 9;
            this.label8.Text = "Date Of Receipt :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 33);
            this.label7.TabIndex = 8;
            this.label7.Text = "Agent Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(527, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 33);
            this.label6.TabIndex = 7;
            this.label6.Text = "Group ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Agent Mob No. :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_agent_id
            // 
            this.tb_agent_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_agent_id.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_agent_id.Location = new System.Drawing.Point(230, 50);
            this.tb_agent_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_agent_id.Multiline = true;
            this.tb_agent_id.Name = "tb_agent_id";
            this.tb_agent_id.Size = new System.Drawing.Size(270, 33);
            this.tb_agent_id.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agent ID :";
            // 
            // Agent_Commission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1467, 686);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Agent_Commission";
            this.Text = "Agent Commission";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_commission_received_date;
        private System.Windows.Forms.Button bt_commission_close;
        private System.Windows.Forms.Button bt_commission_clear;
        private System.Windows.Forms.Button bt_commission_search;
        private System.Windows.Forms.Button bt_commission_save;
        private System.Windows.Forms.Button bt_commission_calculate;
        private System.Windows.Forms.TextBox tb_commission_agent_mob;
        private System.Windows.Forms.TextBox tb_commission_agent_name;
        private System.Windows.Forms.TextBox tb_commission_group_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_agent_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_commission_chit_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_commission_amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_commission_receipt;
    }
}