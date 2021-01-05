﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Cafe_Management_System
{
    public partial class Admin : Form 
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V0HR07H\SQLEXPRESS;Initial Catalog=Cafe Management System;Integrated Security=True");
        String ImgLoc = "";
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void EmpReg_Click(object sender, EventArgs e)
        {
            EmployeeReg Er = new EmployeeReg();
            Er.Show();
            this.Hide();
        }

        private void AdminPassReset_Click(object sender, EventArgs e)
        {
            PasswordReset pr = new PasswordReset();
            pr.Show();
            this.Hide();
        }

        private void EmployeeView_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM [dbo].[EmployeeReg]";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            EmployeeList.DataSource = dt;
            con.Close();
        }

        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AdminLogout_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void ManagerReg_Click(object sender, EventArgs e)
        {
            ManagerUI.ManagerLogin ml = new ManagerUI.ManagerLogin();
            ml.Show();
            this.Hide();
        }

        private void CustomerInfo_Click(object sender, EventArgs e)
        {
            CustomerInfo Ci = new CustomerInfo();
            Ci.Show();
            this.Hide();
        }

        private void FoodView_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM [dbo].[FoodInformation]";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            FoodList.DataSource = dt;
            con.Close();
        }
    }
}
