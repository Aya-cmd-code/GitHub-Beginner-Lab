using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "student@school.edu" && txtPassword.Text == "Password")
            {
                MessageBox.Show("Log in successful!");
            }
            else
            {
                MessageBox.Show("Incorrect email or password.");
            }
        }
    }
}
