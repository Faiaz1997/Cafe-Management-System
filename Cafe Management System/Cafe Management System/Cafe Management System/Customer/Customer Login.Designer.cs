namespace Cafe_Management_System
{
    partial class Customer_Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CLogBack = new System.Windows.Forms.Button();
            this.CustomerLogin = new System.Windows.Forms.Button();
            this.CustomerPass = new System.Windows.Forms.TextBox();
            this.CSignUp = new System.Windows.Forms.Button();
            this.ClogName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Log In as Customer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password";
            // 
            // CLogBack
            // 
            this.CLogBack.BackColor = System.Drawing.Color.Yellow;
            this.CLogBack.Location = new System.Drawing.Point(155, 176);
            this.CLogBack.Name = "CLogBack";
            this.CLogBack.Size = new System.Drawing.Size(75, 23);
            this.CLogBack.TabIndex = 7;
            this.CLogBack.Text = "Back";
            this.CLogBack.UseVisualStyleBackColor = false;
            this.CLogBack.Click += new System.EventHandler(this.AdLogBack_Click);
            // 
            // CustomerLogin
            // 
            this.CustomerLogin.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.CustomerLogin.Location = new System.Drawing.Point(52, 176);
            this.CustomerLogin.Name = "CustomerLogin";
            this.CustomerLogin.Size = new System.Drawing.Size(75, 23);
            this.CustomerLogin.TabIndex = 6;
            this.CustomerLogin.Text = "Sign In";
            this.CustomerLogin.UseVisualStyleBackColor = false;
            // 
            // CustomerPass
            // 
            this.CustomerPass.Location = new System.Drawing.Point(70, 138);
            this.CustomerPass.Name = "CustomerPass";
            this.CustomerPass.PasswordChar = '*';
            this.CustomerPass.Size = new System.Drawing.Size(140, 20);
            this.CustomerPass.TabIndex = 5;
            // 
            // CSignUp
            // 
            this.CSignUp.BackColor = System.Drawing.Color.Orange;
            this.CSignUp.Location = new System.Drawing.Point(197, 226);
            this.CSignUp.Name = "CSignUp";
            this.CSignUp.Size = new System.Drawing.Size(75, 23);
            this.CSignUp.TabIndex = 10;
            this.CSignUp.Text = "Sign Up";
            this.CSignUp.UseVisualStyleBackColor = false;
            this.CSignUp.Click += new System.EventHandler(this.CSignUp_Click);
            // 
            // ClogName
            // 
            this.ClogName.Location = new System.Drawing.Point(70, 68);
            this.ClogName.Name = "ClogName";
            this.ClogName.PasswordChar = '*';
            this.ClogName.Size = new System.Drawing.Size(140, 20);
            this.ClogName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Customer_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CSignUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CLogBack);
            this.Controls.Add(this.CustomerLogin);
            this.Controls.Add(this.ClogName);
            this.Controls.Add(this.CustomerPass);
            this.Name = "Customer_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customer_Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CLogBack;
        private System.Windows.Forms.Button CustomerLogin;
        private System.Windows.Forms.TextBox CustomerPass;
        private System.Windows.Forms.Button CSignUp;
        private System.Windows.Forms.TextBox ClogName;
        private System.Windows.Forms.Label label3;
    }
}