using System;
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

namespace TextRedactor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int starts;
        int ends;
        public MainWindow()
        {
            InitializeComponent();
            cmbColors.ItemsSource = typeof(Colors).GetProperties();
        }

        private void bold_Click(object sender, RoutedEventArgs e)
        {
            var bol = new Bold();
            starts = Convert.ToInt32(start.Text)-1;
            ends = Convert.ToInt32(end.Text) - starts;
            block.Select(starts, ends);
            bol.Inlines.Add(new Run(block.SelectedText));
            var span = new Span();
            span.Inlines.Add(bol);
            
        }
    }
}
