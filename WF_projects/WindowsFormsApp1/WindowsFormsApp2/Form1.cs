using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int number;
        Random rand = new Random();
        int iteration;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game();
        }

        private void Game()
        {
            MessageBox.Show("Загадайте число от 1 до 100\nНажмите ОК для продолжения",
                            "The Game", MessageBoxButtons.OK);
            bool win = false;
            while (win == false)
            {
                number = rand.Next(1, 100);
                iteration++;
                var result = MessageBox.Show($"{number}\nЭто ваше число?", "The Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    win = true;
                }
            }
            MessageBox.Show($"Количество попыток: {iteration}", "Gamescore", MessageBoxButtons.OK);
            var res = MessageBox.Show("Вы хотите сыграть снова?", "The Game", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Game();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
