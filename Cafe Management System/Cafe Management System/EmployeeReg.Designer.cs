namespace Cafe_Management_System
{
    partial class EmployeeReg
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
            this.EmployeeList = new System.Windows.Forms.DataGridView();
            this.EmpPassword = new System.Windows.Forms.TextBox();
            this.EmpEmail = new System.Windows.Forms.TextBox();
            this.EmpPhone = new System.Windows.Forms.TextBox();
            this.EmpAddress = new System.Windows.Forms.TextBox();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.EmpGender = new System.Windows.Forms.ComboBox();
            this.EmpPosition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeList
            // 
            this.EmployeeList.AllowUserToAddRows = false;
            this.EmployeeList.AllowUserToDeleteRows = false;
            this.EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeList.Location = new System.Drawing.Point(26, 40);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.ReadOnly = true;
            this.EmployeeList.Size = new System.Drawing.Size(216, 378);
            this.EmployeeList.TabIndex = 6;
            // 
            // EmpPassword
            // 
            this.EmpPassword.Location = new System.Drawing.Point(397, 229);
            this.EmpPassword.Name = "EmpPassword";
            this.EmpPassword.Size = new System.Drawing.Size(100, 20);
            this.EmpPassword.TabIndex = 7;
            // 
            // EmpEmail
            // 
            this.EmpEmail.Location = new System.Drawing.Point(397, 180);
            this.EmpEmail.Name = "EmpEmail";
            this.EmpEmail.Size = new System.Drawing.Size(100, 20);
            this.EmpEmail.TabIndex = 8;
            // 
            // EmpPhone
            // 
            this.EmpPhone.Location = new System.Drawing.Point(397, 132);
            this.EmpPhone.Name = "EmpPhone";
            this.EmpPhone.Size = new System.Drawing.Size(100, 20);
            this.EmpPhone.TabIndex = 9;
            // 
            // EmpAddress
            // 
            this.EmpAddress.Location = new System.Drawing.Point(397, 83);
            this.EmpAddress.Name = "EmpAddress";
            this.EmpAddress.Size = new System.Drawing.Size(100, 20);
            this.EmpAddress.TabIndex = 10;
            // 
            // EmpName
            // 
            this.EmpName.Location = new System.Drawing.Point(397, 40);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(100, 20);
            this.EmpName.TabIndex = 11;
            // 
            // EmpGender
            // 
            this.EmpGender.FormattingEnabled = true;
            this.EmpGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmpGender.Location = new System.Drawing.Point(397, 280);
            this.EmpGender.Name = "EmpGender";
            this.EmpGender.Size = new System.Drawing.Size(121, 21);
            this.EmpGender.TabIndex = 12;
            this.EmpGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // EmpPosition
            // 
            this.EmpPosition.FormattingEnabled = true;
            this.EmpPosition.Items.AddRange(new object[] {
            "Position"});
            this.EmpPosition.Location = new System.Drawing.Point(397, 334);
            this.EmpPosition.Name = "EmpPosition";
            this.EmpPosition.Size = new System.Drawing.Size(121, 21);
            this.EmpPosition.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "label7";
            // 
            // EmployeeReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmpPosition);
            this.Controls.Add(this.EmpGender);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.EmpAddress);
            this.Controls.Add(this.EmpPhone);
            this.Controls.Add(this.EmpEmail);
            this.Controls.Add(this.EmpPassword);
            this.Controls.Add(this.EmployeeList);
            this.Name = "EmployeeReg";
            this.Text = "EmployeeReg";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeReg_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeList;
        private System.Windows.Forms.TextBox EmpPassword;
        private System.Windows.Forms.TextBox EmpEmail;
        private System.Windows.Forms.TextBox EmpPhone;
        private System.Windows.Forms.TextBox EmpAddress;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.ComboBox EmpGender;
        private System.Windows.Forms.ComboBox EmpPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

    }
}