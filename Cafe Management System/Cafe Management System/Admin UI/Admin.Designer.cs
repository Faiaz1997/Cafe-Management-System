﻿namespace Cafe_Management_System
{
    partial class Admin
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
            this.EmpReg = new System.Windows.Forms.Button();
            this.ManagerReg = new System.Windows.Forms.Button();
            this.CustomerInfo = new System.Windows.Forms.Button();
            this.AdminPassReset = new System.Windows.Forms.Button();
            this.AdminLogout = new System.Windows.Forms.Button();
            this.EmployeeList = new System.Windows.Forms.DataGridView();
            this.FoodList = new System.Windows.Forms.DataGridView();
            this.FoodView = new System.Windows.Forms.Button();
            this.EmployeeView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodList)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpReg
            // 
            this.EmpReg.BackColor = System.Drawing.Color.Orange;
            this.EmpReg.Location = new System.Drawing.Point(75, 56);
            this.EmpReg.Name = "EmpReg";
            this.EmpReg.Size = new System.Drawing.Size(75, 23);
            this.EmpReg.TabIndex = 0;
            this.EmpReg.Text = "Employee";
            this.EmpReg.UseVisualStyleBackColor = false;
            this.EmpReg.Click += new System.EventHandler(this.EmpReg_Click);
            // 
            // ManagerReg
            // 
            this.ManagerReg.BackColor = System.Drawing.Color.Orange;
            this.ManagerReg.Location = new System.Drawing.Point(75, 127);
            this.ManagerReg.Name = "ManagerReg";
            this.ManagerReg.Size = new System.Drawing.Size(75, 23);
            this.ManagerReg.TabIndex = 1;
            this.ManagerReg.Text = "Manager";
            this.ManagerReg.UseVisualStyleBackColor = false;
            this.ManagerReg.Click += new System.EventHandler(this.ManagerReg_Click);
            // 
            // CustomerInfo
            // 
            this.CustomerInfo.BackColor = System.Drawing.Color.Orange;
            this.CustomerInfo.Location = new System.Drawing.Point(75, 198);
            this.CustomerInfo.Name = "CustomerInfo";
            this.CustomerInfo.Size = new System.Drawing.Size(75, 23);
            this.CustomerInfo.TabIndex = 2;
            this.CustomerInfo.Text = "Customer";
            this.CustomerInfo.UseVisualStyleBackColor = false;
            this.CustomerInfo.Click += new System.EventHandler(this.CustomerInfo_Click);
            // 
            // AdminPassReset
            // 
            this.AdminPassReset.BackColor = System.Drawing.Color.Orange;
            this.AdminPassReset.Location = new System.Drawing.Point(75, 269);
            this.AdminPassReset.Name = "AdminPassReset";
            this.AdminPassReset.Size = new System.Drawing.Size(75, 23);
            this.AdminPassReset.TabIndex = 3;
            this.AdminPassReset.Text = "Reset Pass";
            this.AdminPassReset.UseVisualStyleBackColor = false;
            this.AdminPassReset.Click += new System.EventHandler(this.AdminPassReset_Click);
            // 
            // AdminLogout
            // 
            this.AdminLogout.BackColor = System.Drawing.Color.Orange;
            this.AdminLogout.Location = new System.Drawing.Point(75, 340);
            this.AdminLogout.Name = "AdminLogout";
            this.AdminLogout.Size = new System.Drawing.Size(75, 23);
            this.AdminLogout.TabIndex = 4;
            this.AdminLogout.Text = "Sign Out";
            this.AdminLogout.UseVisualStyleBackColor = false;
            this.AdminLogout.Click += new System.EventHandler(this.AdminLogout_Click);
            // 
            // EmployeeList
            // 
            this.EmployeeList.AllowUserToAddRows = false;
            this.EmployeeList.AllowUserToDeleteRows = false;
            this.EmployeeList.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeList.Location = new System.Drawing.Point(258, 12);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.ReadOnly = true;
            this.EmployeeList.Size = new System.Drawing.Size(216, 378);
            this.EmployeeList.TabIndex = 5;
            this.EmployeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeList_CellContentClick);
            // 
            // FoodList
            // 
            this.FoodList.AllowUserToAddRows = false;
            this.FoodList.AllowUserToDeleteRows = false;
            this.FoodList.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.FoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoodList.Location = new System.Drawing.Point(492, 12);
            this.FoodList.Name = "FoodList";
            this.FoodList.ReadOnly = true;
            this.FoodList.Size = new System.Drawing.Size(216, 378);
            this.FoodList.TabIndex = 6;
            // 
            // FoodView
            // 
            this.FoodView.BackColor = System.Drawing.Color.LightSeaGreen;
            this.FoodView.Location = new System.Drawing.Point(633, 407);
            this.FoodView.Name = "FoodView";
            this.FoodView.Size = new System.Drawing.Size(75, 23);
            this.FoodView.TabIndex = 7;
            this.FoodView.Text = "Refresh";
            this.FoodView.UseVisualStyleBackColor = false;
            this.FoodView.Click += new System.EventHandler(this.FoodView_Click);
            // 
            // EmployeeView
            // 
            this.EmployeeView.BackColor = System.Drawing.Color.LightSeaGreen;
            this.EmployeeView.Location = new System.Drawing.Point(399, 407);
            this.EmployeeView.Name = "EmployeeView";
            this.EmployeeView.Size = new System.Drawing.Size(75, 23);
            this.EmployeeView.TabIndex = 8;
            this.EmployeeView.Text = "Refresh";
            this.EmployeeView.UseVisualStyleBackColor = false;
            this.EmployeeView.Click += new System.EventHandler(this.EmployeeView_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.EmployeeView);
            this.Controls.Add(this.FoodView);
            this.Controls.Add(this.FoodList);
            this.Controls.Add(this.EmployeeList);
            this.Controls.Add(this.AdminLogout);
            this.Controls.Add(this.AdminPassReset);
            this.Controls.Add(this.CustomerInfo);
            this.Controls.Add(this.ManagerReg);
            this.Controls.Add(this.EmpReg);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EmpReg;
        private System.Windows.Forms.Button ManagerReg;
        private System.Windows.Forms.Button CustomerInfo;
        private System.Windows.Forms.Button AdminPassReset;
        private System.Windows.Forms.Button AdminLogout;
        private System.Windows.Forms.DataGridView EmployeeList;
        private System.Windows.Forms.DataGridView FoodList;
        private System.Windows.Forms.Button FoodView;
        private System.Windows.Forms.Button EmployeeView;
    }
}