namespace Cafe_Management_System.Admin_UI
{
    partial class Customer_Registration
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.CustomerAddress = new System.Windows.Forms.TextBox();
            this.CustomerPhone = new System.Windows.Forms.TextBox();
            this.CustomerEmail = new System.Windows.Forms.TextBox();
            this.CustomerPassword = new System.Windows.Forms.TextBox();
            this.CustomerUpdate = new System.Windows.Forms.Button();
            this.CustomerAdd = new System.Windows.Forms.Button();
            this.CustomerBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Name";
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(141, 52);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(100, 20);
            this.CustomerName.TabIndex = 24;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.Location = new System.Drawing.Point(141, 95);
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.Size = new System.Drawing.Size(100, 20);
            this.CustomerAddress.TabIndex = 23;
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.Location = new System.Drawing.Point(141, 144);
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.Size = new System.Drawing.Size(100, 20);
            this.CustomerPhone.TabIndex = 22;
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.Location = new System.Drawing.Point(141, 192);
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.Size = new System.Drawing.Size(100, 20);
            this.CustomerEmail.TabIndex = 21;
            // 
            // CustomerPassword
            // 
            this.CustomerPassword.Location = new System.Drawing.Point(141, 241);
            this.CustomerPassword.Name = "CustomerPassword";
            this.CustomerPassword.Size = new System.Drawing.Size(100, 20);
            this.CustomerPassword.TabIndex = 20;
            // 
            // CustomerUpdate
            // 
            this.CustomerUpdate.Location = new System.Drawing.Point(375, 314);
            this.CustomerUpdate.Name = "CustomerUpdate";
            this.CustomerUpdate.Size = new System.Drawing.Size(75, 23);
            this.CustomerUpdate.TabIndex = 32;
            this.CustomerUpdate.Text = "Update";
            this.CustomerUpdate.UseVisualStyleBackColor = true;
            // 
            // CustomerAdd
            // 
            this.CustomerAdd.Location = new System.Drawing.Point(291, 314);
            this.CustomerAdd.Name = "CustomerAdd";
            this.CustomerAdd.Size = new System.Drawing.Size(75, 23);
            this.CustomerAdd.TabIndex = 31;
            this.CustomerAdd.Text = "Add";
            this.CustomerAdd.UseVisualStyleBackColor = true;
            this.CustomerAdd.Click += new System.EventHandler(this.CustomerAdd_Click);
            // 
            // CustomerBack
            // 
            this.CustomerBack.Location = new System.Drawing.Point(456, 314);
            this.CustomerBack.Name = "CustomerBack";
            this.CustomerBack.Size = new System.Drawing.Size(75, 23);
            this.CustomerBack.TabIndex = 33;
            this.CustomerBack.Text = "Back";
            this.CustomerBack.UseVisualStyleBackColor = true;
            this.CustomerBack.Click += new System.EventHandler(this.CustomerBack_Click);
            // 
            // Customer_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(560, 373);
            this.Controls.Add(this.CustomerBack);
            this.Controls.Add(this.CustomerUpdate);
            this.Controls.Add(this.CustomerAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.CustomerAddress);
            this.Controls.Add(this.CustomerPhone);
            this.Controls.Add(this.CustomerEmail);
            this.Controls.Add(this.CustomerPassword);
            this.Name = "Customer_Registration";
            this.Text = "Customer Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customer_Registration_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.TextBox CustomerAddress;
        private System.Windows.Forms.TextBox CustomerPhone;
        private System.Windows.Forms.TextBox CustomerEmail;
        private System.Windows.Forms.TextBox CustomerPassword;
        private System.Windows.Forms.Button CustomerUpdate;
        private System.Windows.Forms.Button CustomerAdd;
        private System.Windows.Forms.Button CustomerBack;
    }
}