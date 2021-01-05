using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cafe_Management_System
{
    public partial class CustomerInfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V0HR07H\SQLEXPRESS;Initial Catalog=Cafe Management System;Integrated Security=True");
        public CustomerInfo()
        {
            InitializeComponent();
        }

        private void CustomerInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CustomerView_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT Name,Address,Phone,Email FROM [dbo].[CustomerReg]";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CustomerData.DataSource = dt;
            con.Close();
        }

        private void EmpBack_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }
    }
}
