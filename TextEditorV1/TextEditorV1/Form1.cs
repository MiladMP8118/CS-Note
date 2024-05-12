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
namespace TextEditorV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "My open file dialog";
            openFileDialog1.Filter = "Text Files(.txt)|*.txt|All Files (.)|*.*";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                using (StreamReader sr = new StreamReader(openfile.FileName))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save your File";
            saveFileDialog1.Filter = "Text Files(.txt)|*.txt|Rich text file|*rtf|Word Document|*.docx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save your document";
            saveFileDialog1.Filter = "All Files (.)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
    }
}
