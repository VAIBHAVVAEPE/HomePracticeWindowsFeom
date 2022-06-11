using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePracticeWindowsFeom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butReset_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtLogin.Clear();
        }

        private void butSubmit_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Admin" && txtPassword.Text == "1234") 
            {
                MessageBox.Show("Login success");
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }
    }
}
