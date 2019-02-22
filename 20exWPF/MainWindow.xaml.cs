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
using _20Ex;
namespace WpfApp1
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

        private void Program_1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(ex1.exer1());
        }

        private void Program_2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(ex2.exer2(Name.Text));
        }

        private void Program_3_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if ((bool)loud.IsChecked)
                mes = "loud";
            if ((bool)quiet.IsChecked)
                mes = "quiet";
            MessageBox.Show(ex3.exer3(Name.Text, mes));
        }
    }
}
