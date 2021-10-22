
namespace Chit_Fund_Management_System
{
    partial class Employee_Salary_Slip_Print
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
            this.crv_salary_slip = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_salary_slip
            // 
            this.crv_salary_slip.ActiveViewIndex = -1;
            this.crv_salary_slip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_salary_slip.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_salary_slip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_salary_slip.Location = new System.Drawing.Point(0, 0);
            this.crv_salary_slip.Name = "crv_salary_slip";
            this.crv_salary_slip.Size = new System.Drawing.Size(1465, 686);
            this.crv_salary_slip.TabIndex = 0;
            // 
            // Employee_Salary_Slip_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 686);
            this.Controls.Add(this.crv_salary_slip);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Employee_Salary_Slip_Print";
            this.Text = "Employee Salary Slip";
            this.Load += new System.EventHandler(this.Employee_Salary_Slip_Print_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_salary_slip;
    }
}