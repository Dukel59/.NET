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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files(*.*)|*.*|Text Files (*.txt)|*.txt|PDF (*.pdf)|*.pdf||";
            open.FilterIndex = comboBox1.SelectedIndex + 1;
            open.InitialDirectory = textBox1.Text;
            open.Multiselect = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.AddRange(open.SafeFileNames);
            }
        }
    }
}
