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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
         int i = 0;
        int k, inkr;
        string path = @"C:\WF_project\WindowsFormsApp2\WindowsFormsApp2\new.txt";
        string line;
        List<string> lines = new List<string>();
        public Form1()
        {
            InitializeComponent();

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line);
                    i++;
                }
                inkr = 100 / i;
                k = i++;
                i = 0;
            }
        }

        private void Read()
        {
            if (i != k)
            {
                listBox1.Items.Clear();             
                listBox1.Items.Add(lines[i]);
                i++;
            }
            else
            {
                var result = MessageBox.Show("THE END!", "END", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                if(result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Read();
            progressBar1.Increment(inkr);
        }
    }
}
