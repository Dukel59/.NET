using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            backspace.Content = "<";

            foreach (UIElement element in root.Children)
            {
                if (element is Button)
                {
                    ((Button)element).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            string str = but.Content.ToString();

            if(str == "1" || str == "2" || str == "3" || str == "4" || str == "5" ||
                str == "6" || str == "7" || str == "8" || str == "9" || str == "0")//деление на ноль
            {
                bottom.Text += str;
            }

            switch (str)
            {
                case "CE":
                    bottom.Clear();
                    break;
                case "C":
                    bottom.Clear();
                    top.Clear();
                    break;
                case "<":
                    bottom.Text = bottom.Text.Remove(bottom.Text.Length - 1, 1);
                    break;
                case "/":
                    if (bottom.Text.Length > 0)
                    {
                        bottom.Text += "/";
                    }
                    else
                    {
                        MessageBox.Show("Пустая строка!");
                    }
                    break;
                case "*":
                    if (bottom.Text.Length > 0)
                    {
                        bottom.Text += "*";
                    }
                    else
                    {
                        MessageBox.Show("Пустая строка!");
                    }
                    break;
                case "-":
                    if (bottom.Text.Length > 0)
                    {
                        bottom.Text += "-";
                    }
                    else
                    {
                        MessageBox.Show("Пустая строка!");
                    }
                    break;
                case "+":
                    if (bottom.Text.Length > 0)
                    {
                        bottom.Text += "+";
                    }
                    else
                    {
                        MessageBox.Show("Пустая строка!");
                    }
                    break;
                case ".":
                    if (bottom.Text.EndsWith("/") || bottom.Text.EndsWith("*") ||
                        bottom.Text.EndsWith("-") || bottom.Text.EndsWith("+") ||
                        bottom.Text.Length ==0)
                    {
                        bottom.Text += "0.";
                    }
                    else if (bottom.Text.Length >0)
                    {
                        bottom.Text += ".";
                    }
                    else
                    {
                        MessageBox.Show("Пустая строка!");
                    }
                    break;
                case "=":
                    if(bottom.Text.EndsWith("."))
                    {
                        bottom.Text += "0";
                    }
                    if (bottom.Text.EndsWith("/")|| bottom.Text.EndsWith("*") ||
                        bottom.Text.EndsWith("-") || bottom.Text.EndsWith("+"))
                    {
                        MessageBox.Show("Введите выражение");
                    }
                    else
                    {
                        string solution = new DataTable().Compute(bottom.Text, null).ToString();
                        top.Text = bottom.Text;
                        bottom.Text = solution;
                    }
                    break;
            }
        }
    }
}
