using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04
{
    public partial class Form1 : Form
    {
        TextBox[] textboxes;
        public Form1()
        {
            InitializeComponent();

            textboxes = new TextBox[5];

            textboxes[0] = textBox1;
            textboxes[1] = textBox2;
            textboxes[2] = textBox3;
            textboxes[3] = textBox4;
            textboxes[4] = textBox5;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
            
            for (int idx = 0; idx < textboxes.Length; idx++)
            {
                int num = idx + 1;

                if (string.IsNullOrEmpty(textboxes[idx].Text))
                {
                    richTextBox1.AppendText("Елемент " + num + ": Порожньо\n");
                }
                else
                {
                    richTextBox1.AppendText("Елемент " + num + ": " + textboxes[idx].Text + "\n");
                }
            }
        }
    }
}
