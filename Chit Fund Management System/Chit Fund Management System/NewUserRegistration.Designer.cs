﻿
namespace Chit_Fund_Management_System
{
    partial class f_newuser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_newuser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_clear_new_user = new System.Windows.Forms.Button();
            this.creatBT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_passwordnew = new System.Windows.Forms.TextBox();
            this.tb_usertype = new System.Windows.Forms.TextBox();
            this.tb_usernamenew = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New UserName :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(848, 70);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create New User For System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Create New Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Type :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.bt_close);
            this.groupBox1.Controls.Add(this.bt_clear_new_user);
            this.groupBox1.Controls.Add(this.creatBT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_passwordnew);
            this.groupBox1.Controls.Add(this.tb_usertype);
            this.groupBox1.Controls.Add(this.tb_usernamenew);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(236, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 446);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New User";
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.Gray;
            this.bt_close.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_close.Location = new System.Drawing.Point(695, 343);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(126, 42);
            this.bt_close.TabIndex = 11;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_clear_new_user
            // 
            this.bt_clear_new_user.BackColor = System.Drawing.Color.Gray;
            this.bt_clear_new_user.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clear_new_user.Location = new System.Drawing.Point(400, 343);
            this.bt_clear_new_user.Name = "bt_clear_new_user";
            this.bt_clear_new_user.Size = new System.Drawing.Size(149, 42);
            this.bt_clear_new_user.TabIndex = 10;
            this.bt_clear_new_user.Text = "Clear";
            this.bt_clear_new_user.UseVisualStyleBackColor = false;
            this.bt_clear_new_user.Click += new System.EventHandler(this.bt_clear_new_user_Click);
            // 
            // creatBT
            // 
            this.creatBT.BackColor = System.Drawing.Color.Gray;
            this.creatBT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatBT.Location = new System.Drawing.Point(95, 343);
            this.creatBT.Name = "creatBT";
            this.creatBT.Size = new System.Drawing.Size(139, 42);
            this.creatBT.TabIndex = 9;
            this.creatBT.Text = "Create";
            this.creatBT.UseVisualStyleBackColor = false;
            this.creatBT.Click += new System.EventHandler(this.creatBT_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(596, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Admin or Employee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(596, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "should be 6 character";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(596, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "should be unique from existing";
            // 
            // tb_passwordnew
            // 
            this.tb_passwordnew.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_passwordnew.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passwordnew.Location = new System.Drawing.Point(599, 144);
            this.tb_passwordnew.Multiline = true;
            this.tb_passwordnew.Name = "tb_passwordnew";
            this.tb_passwordnew.Size = new System.Drawing.Size(222, 38);
            this.tb_passwordnew.TabIndex = 6;
            // 
            // tb_usertype
            // 
            this.tb_usertype.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_usertype.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_usertype.Location = new System.Drawing.Point(599, 228);
            this.tb_usertype.Multiline = true;
            this.tb_usertype.Name = "tb_usertype";
            this.tb_usertype.Size = new System.Drawing.Size(222, 38);
            this.tb_usertype.TabIndex = 5;
            // 
            // tb_usernamenew
            // 
            this.tb_usernamenew.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_usernamenew.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_usernamenew.Location = new System.Drawing.Point(599, 50);
            this.tb_usernamenew.Multiline = true;
            this.tb_usernamenew.Name = "tb_usernamenew";
            this.tb_usernamenew.Size = new System.Drawing.Size(222, 38);
            this.tb_usernamenew.TabIndex = 4;
            // 
            // f_newuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1334, 699);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "f_newuser";
            this.Text = "New User Registration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_passwordnew;
        private System.Windows.Forms.TextBox tb_usertype;
        private System.Windows.Forms.TextBox tb_usernamenew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button creatBT;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_clear_new_user;
    }
}