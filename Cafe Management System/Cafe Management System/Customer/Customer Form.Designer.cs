namespace Cafe_Management_System.Customer
{
    partial class Customer_Form
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
            this.CustomerBack = new System.Windows.Forms.Button();
            this.CustomerAdd = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // CustomerBack
            // 
            this.CustomerBack.Location = new System.Drawing.Point(468, 345);
            this.CustomerBack.Name = "CustomerBack";
            this.CustomerBack.Size = new System.Drawing.Size(75, 23);
            this.CustomerBack.TabIndex = 46;
            this.CustomerBack.Text = "Back";
            this.CustomerBack.UseVisualStyleBackColor = true;
            this.CustomerBack.Click += new System.EventHandler(this.CustomerBack_Click);
            // 
            // CustomerAdd
            // 
            this.CustomerAdd.Location = new System.Drawing.Point(387, 345);
            this.CustomerAdd.Name = "CustomerAdd";
            this.CustomerAdd.Size = new System.Drawing.Size(75, 23);
            this.CustomerAdd.TabIndex = 44;
            this.CustomerAdd.Text = "Add";
            this.CustomerAdd.UseVisualStyleBackColor = true;
            this.CustomerAdd.Click += new System.EventHandler(this.CustomerAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Name";
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(153, 83);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(100, 20);
            this.CustomerName.TabIndex = 38;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.Location = new System.Drawing.Point(153, 126);
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.Size = new System.Drawing.Size(100, 20);
            this.CustomerAddress.TabIndex = 37;
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.Location = new System.Drawing.Point(153, 175);
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.Size = new System.Drawing.Size(100, 20);
            this.CustomerPhone.TabIndex = 36;
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.Location = new System.Drawing.Point(153, 223);
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.Size = new System.Drawing.Size(100, 20);
            this.CustomerEmail.TabIndex = 35;
            // 
            // CustomerPassword
            // 
            this.CustomerPassword.Location = new System.Drawing.Point(153, 272);
            this.CustomerPassword.Name = "CustomerPassword";
            this.CustomerPassword.Size = new System.Drawing.Size(100, 20);
            this.CustomerPassword.TabIndex = 34;
            // 
            // Customer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(608, 451);
            this.Controls.Add(this.CustomerBack);
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
            this.Name = "Customer_Form";
            this.Text = "Customer_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customer_Form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CustomerBack;
        private System.Windows.Forms.Button CustomerAdd;
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
    }
}