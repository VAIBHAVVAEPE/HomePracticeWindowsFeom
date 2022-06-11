using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HomePracticeWindowsFeom
{
    public partial class Course_Form : Form
    {

        FileStream fs;//this is used
        



        public Course_Form()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            
            try
            {
                 fs = new FileStream(@"D:\SnQBatch\Test1.txt", FileMode.Create, FileAccess.Write);

                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtID.Text));
                bw.Write(txtName.Text);
                bw.Write(Convert.ToInt32(txtFees.Text));
                bw.Close();
                MessageBox.Show("Done");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs =new FileStream(@"D:\SnQBatch\Test1.txt",FileMode.Open,FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                txtID.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtFees.Text = br.ReadInt32().ToString();
                br.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
