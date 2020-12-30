using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class Admin : Form
    {
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
    }
}
