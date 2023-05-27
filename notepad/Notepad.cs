using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

            
        
        private void Notepad_Load_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            text.Font = fontDialog1.Font;
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.Clear();
        }


        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "all text (*Rs)| *.Rs";
            openFileDialog1.FileName = "";
            var d = openFileDialog1.ShowDialog();
            if (d == System.Windows.Forms.DialogResult.OK)
            {
                text.LoadFile(openFileDialog1.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "all text (*Rs)| *.Rs";
            var r = saveFileDialog1.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                text.SaveFile(saveFileDialog1.FileName);
            }
        }

        private void undoCtrlYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.Undo();
        }

        private void copyCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.Cut();
        }

        private void pasteCtrlVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.Copy();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.Paste();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.SelectAll();
        }

        private void timeDateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            text.Text += DateTime.Now.ToString();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.SelectedText = "";
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            text.SelectionBackColor = colorDialog1.Color;
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            text.ForeColor = colorDialog1.Color;
        }

        private void selectFontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            text.SelectionColor = colorDialog1.Color;
        }

        private void selectBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            text.SelectionBackColor = colorDialog1.Color;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lines_Click(object sender, EventArgs e)
        {

        }
        public void wordcount()
        {
            int count = 0;
            string word = text.Text;
            for (int i = 0; i < word.Length; i++)
             {
                if(word[i] ==' ')
                {
                    if(word[i-1]!=' ')
                    {
                        count++;
                    }
                }
                lblwo.Text = count.ToString();
            }

        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int words = text.Text.Split(' ').Count();
            wordcount();
            int lines1 = text.Lines.Count();
            lines.Text = lines1.ToString();
        }
    }
}
