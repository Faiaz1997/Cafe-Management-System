namespace Cafe_Management_System
{
    partial class CustomerInfo
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
            this.CustomerData = new System.Windows.Forms.DataGridView();
            this.CustomerView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerData)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerData
            // 
            this.CustomerData.AllowUserToAddRows = false;
            this.CustomerData.AllowUserToDeleteRows = false;
            this.CustomerData.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.CustomerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerData.Location = new System.Drawing.Point(41, 12);
            this.CustomerData.Name = "CustomerData";
            this.CustomerData.ReadOnly = true;
            this.CustomerData.Size = new System.Drawing.Size(697, 334);
            this.CustomerData.TabIndex = 0;
            // 
            // CustomerView
            // 
            this.CustomerView.BackColor = System.Drawing.Color.Orange;
            this.CustomerView.Location = new System.Drawing.Point(663, 399);
            this.CustomerView.Name = "CustomerView";
            this.CustomerView.Size = new System.Drawing.Size(75, 23);
            this.CustomerView.TabIndex = 9;
            this.CustomerView.Text = "View";
            this.CustomerView.UseVisualStyleBackColor = false;
            this.CustomerView.Click += new System.EventHandler(this.CustomerView_Click);
            // 
            // CustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.CustomerView);
            this.Controls.Add(this.CustomerData);
            this.Name = "CustomerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerInfo_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerData;
        private System.Windows.Forms.Button CustomerView;
    }
}