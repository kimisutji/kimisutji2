using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛБ_1_ПУРБУЕВ
{
    public partial class Form1 : Form
    {
        string fileName; // имя редактируемого файла
        public Form1()
        {
            InitializeComponent();
            fileName = Properties.Resources.defaultFileName;
            toolStripStatusLabel1.Text = fileName;

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            fileName = Properties.Resources.defaultFileName;
            toolStripStatusLabel1.Text = fileName;
        }

        private void opejnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() ==
                System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
                fileName = openFileDialog1.FileName;
                toolStripStatusLabel1.Text = fileName;
            }
        }

        private void saveasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = fileName;
            saveFileDialog1.InitialDirectory =
            Directory.GetCurrentDirectory();
            if (saveFileDialog1.ShowDialog() ==
            System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                fileName = saveFileDialog1.FileName;
                toolStripStatusLabel1.Text = fileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName.Equals(Properties.Resources.defaultFileName))
            {
                saveToolStripMenuItem_Click(sender, e);
            }
            else richTextBox1.SaveFile(fileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy(); // скопировать в буфер обмена 
                                 // выделенный фрагмент текста.
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut(); // скопировать в буфер обмена 
                                // выделенный фрагмент текста 
                                // и удалить этот фрагмент 
                                // из поля ввода.

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();// вставить фрагмент текста 
                                 // из буфера обмена 
                                 // в позицию курсора

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }
    }
    }
    

