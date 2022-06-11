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
    public partial class Employee_Data_From : Form
    {
        public Employee_Data_From()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmpId.Clear();
            txtdepName.Clear();
            txtMobileNo.Clear();
            txtSalary.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" EmpId = " + txtEmpId.Text + " Emp_Name = " + txtdepName.Text + " Emp_Mobl= " + txtMobileNo.Text + "Emp_Salary="+txtSalary.Text);
        }
    }
}
