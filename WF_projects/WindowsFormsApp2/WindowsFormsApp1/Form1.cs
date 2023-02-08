using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeText()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(label1.Text + ": " + textBox1.Text);
            listBox1.Items.Add(label2.Text + ": " + textBox2.Text);
            listBox1.Items.Add(label3.Text + ": " + textBox3.Text);
            listBox1.Items.Add(label4.Text + ": " + textBox4.Text);
            listBox1.Items.Add(label5.Text + ": " + textBox5.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ChangeText();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ChangeText();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ChangeText();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ChangeText();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            ChangeText();
        }
    }
}
