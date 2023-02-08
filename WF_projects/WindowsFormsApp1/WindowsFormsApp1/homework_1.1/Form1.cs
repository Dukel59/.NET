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
        DateTime day;
        public Form1()
        {
            InitializeComponent();   
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                day = Convert.ToDateTime(textBox1.Text);
                label1.Text = day.DayOfWeek.ToString();

                switch (day.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        label2.Text = "Понедельник";
                        break;
                    case DayOfWeek.Tuesday:
                        label2.Text = "Вторник";
                        break;
                    case DayOfWeek.Wednesday:
                        label2.Text = "Среда";
                        break;
                    case DayOfWeek.Thursday:
                        label2.Text = "Четверг";
                        break;
                    case DayOfWeek.Friday:
                        label2.Text = "Пятница";
                        break;
                    case DayOfWeek.Saturday:
                        label2.Text = "Суббота";
                        break;
                    case DayOfWeek.Sunday:
                        label2.Text = "Воскресенье";
                        break;
                }
            }
            else
            {
                MessageBox.Show("TextBox is empty");
            }
        }
    }
}
