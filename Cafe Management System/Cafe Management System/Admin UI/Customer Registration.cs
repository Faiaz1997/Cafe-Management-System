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

namespace Cafe_Management_System.Admin_UI
{
    public partial class Customer_Registration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V0HR07H\SQLEXPRESS;Initial Catalog=Cafe Management System;Integrated Security=True");
        public Customer_Registration()
        {
            InitializeComponent();
        }

        private void CustomerBack_Click(object sender, EventArgs e)
        {
            Customer_Login cl = new Customer_Login();
            cl.Show();
            this.Hide();
        }

        private void Customer_Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CustomerAdd_Click(object sender, EventArgs e)
        {
           
                con.Open();
                if (CustomerName.Text == "")
                    MessageBox.Show("Please enter employee Name");
                else if (CustomerAddress.Text == "")
                    MessageBox.Show("Please enter Address");
                else if (CustomerPhone.Text == "")
                    MessageBox.Show("Please enter Phone No");
                else if (CustomerEmail.Text == "")
                    MessageBox.Show("Please enter Email Address");
                else if (CustomerPassword.Text == "")
                    MessageBox.Show("Please enter Password");
                else
                {
                    string sql = "INSERT INTO [dbo].[CustomerReg]([Name],[Address],[Phone],[Email],[Password])VALUES('" + CustomerName.Text + "','" + CustomerAddress.Text + "','" + CustomerPhone.Text + "','" + CustomerEmail.Text + "','" + CustomerPassword.Text + "')";

                    SqlCommand command = new SqlCommand(sql, con);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Employee added successfully");
                        CustomerName.Text = string.Empty;
                        CustomerAddress.Text = string.Empty;
                        CustomerPhone.Text = string.Empty;
                        CustomerEmail.Text = string.Empty;
                        CustomerPassword.Text = string.Empty;
                    }
                    else
                        MessageBox.Show("Error in adding Customer");

                }

                con.Close();
            }
         
        }
 }
