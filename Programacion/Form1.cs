using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Programacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName + ".txt", richTextBox1.Text);
                MessageBox.Show("Archivo guardado");
            }
            richTextBox1.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            openFileDialog1.Title = "Escoje el archivo";
            openFileDialog1.Filter = "Textos |  *.txt";
            if (openFileDialog1.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {                
                    richTextBox1.LoadFile(openFileDialog1.FileName,RichTextBoxStreamType.PlainText);                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SaveFileDialog SF = new SaveFileDialog();
            SF.Filter = " Textos |*.txt";
            SF.Title = "Archivo";
            if (SF.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { using (var savef = new StreamWriter(SF.FileName + ".txt"))
                {
                    savef.Write(richTextBox1.Text);
                    savef.Write(richTextBox2.Text);
                }
            }
            MessageBox.Show("Guardado");
            
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            openFileDialog1.Title = "Escoje el archivo";
            openFileDialog1.Filter = "Textos |  *.txt";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox2.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void abrirToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox3.Clear();
            openFileDialog1.Title = "Escoje el archivo";
            openFileDialog1.Filter = "Textos |  *.txt";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox3.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        
    }
}
