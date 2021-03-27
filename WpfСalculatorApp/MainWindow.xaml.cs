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

namespace WpfСalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (this.Width <550)
            {
                Jurnal.Width = new GridLength(0);
            }
            else
            {
                Jurnal.Width = new GridLength(220);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            JournalLabel.Foreground = new SolidColorBrush(Color.FromRgb(32, 54, 253));
            MemoryLabel.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MemoryLabel.Foreground = new SolidColorBrush(Color.FromRgb(32, 54, 253));
            JournalLabel.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }
    }
}
