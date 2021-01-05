namespace Cafe_Management_System
{
    partial class Home
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
            this.AdminLog = new System.Windows.Forms.Button();
            this.ManagerLog = new System.Windows.Forms.Button();
            this.CustomerLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminLog
            // 
            this.AdminLog.BackColor = System.Drawing.Color.Orange;
            this.AdminLog.Location = new System.Drawing.Point(114, 77);
            this.AdminLog.Name = "AdminLog";
            this.AdminLog.Size = new System.Drawing.Size(75, 23);
            this.AdminLog.TabIndex = 0;
            this.AdminLog.Text = "Admin";
            this.AdminLog.UseVisualStyleBackColor = false;
            this.AdminLog.Click += new System.EventHandler(this.AdminLog_Click);
            // 
            // ManagerLog
            // 
            this.ManagerLog.BackColor = System.Drawing.Color.Orange;
            this.ManagerLog.Location = new System.Drawing.Point(114, 125);
            this.ManagerLog.Name = "ManagerLog";
            this.ManagerLog.Size = new System.Drawing.Size(75, 23);
            this.ManagerLog.TabIndex = 1;
            this.ManagerLog.Text = "Manager";
            this.ManagerLog.UseVisualStyleBackColor = false;
            this.ManagerLog.Click += new System.EventHandler(this.ManagerLog_Click);
            // 
            // CustomerLog
            // 
            this.CustomerLog.BackColor = System.Drawing.Color.Orange;
            this.CustomerLog.Location = new System.Drawing.Point(114, 174);
            this.CustomerLog.Name = "CustomerLog";
            this.CustomerLog.Size = new System.Drawing.Size(75, 23);
            this.CustomerLog.TabIndex = 2;
            this.CustomerLog.Text = "Customer";
            this.CustomerLog.UseVisualStyleBackColor = false;
            this.CustomerLog.Click += new System.EventHandler(this.button3_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(313, 299);
            this.Controls.Add(this.CustomerLog);
            this.Controls.Add(this.ManagerLog);
            this.Controls.Add(this.AdminLog);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminLog;
        private System.Windows.Forms.Button ManagerLog;
        private System.Windows.Forms.Button CustomerLog;
    }
}