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

namespace Notepad_Demo_From
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Text doc(.txt)|*.txt|word doc(.docx)|*.docx|Pdf file(.pdf)|*.pdf|All file|*.*";
            DialogResult result = od.ShowDialog();

            if(result==DialogResult.OK)
            {
                StreamReader sr = new StreamReader(od.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.DefaultExt = ".txt";
            sd.Filter= "Text doc(.txt)|*.txt|word doc(.docx)|*.docx|Pdf file(.pdf)|*.pdf|All file|*.*";
            DialogResult result = sd.ShowDialog();
            if(result==DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sd.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Due u want to Exit ? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result==DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            DialogResult result = fd.ShowDialog();
            if(DialogResult.OK==result)
            {
                richTextBox1.SelectionFont = fd.Font;
            }
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult result = cd.ShowDialog();
            if(DialogResult.OK==result)
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void cppyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.DeselectAll();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
    }
}
