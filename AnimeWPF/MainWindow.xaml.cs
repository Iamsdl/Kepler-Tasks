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

namespace Anime2
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

        private void Browse_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Path_Drop(object sender, DragEventArgs e)
        {
            path.Text = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
        }

        private void Add_image_Click(object sender, RoutedEventArgs e)
        {
            imgtest.Source = new ImageSourceConverter().ConvertFromString(path.Text) as ImageSource;
        }
    }
}
