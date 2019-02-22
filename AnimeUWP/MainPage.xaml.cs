using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Main
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void All_Checked(object sender, RoutedEventArgs e)
        {
            Menu.Margin = new Windows.UI.Xaml.Thickness(0, 0, 0, 0);
        }

        private void All_Unchecked(object sender, RoutedEventArgs e)
        {
            Menu.Margin = new Windows.UI.Xaml.Thickness(0, -320, 0, 0);
        }

        private void AnimeMenuButton_Checked(object sender, RoutedEventArgs e)
        {
            MenuAnime.Margin = new Windows.UI.Xaml.Thickness(0, 0, 0, 0);
        }

        private void AnimeMenuButton_Unchecked(object sender, RoutedEventArgs e)
        {
            MenuAnime.Margin = new Windows.UI.Xaml.Thickness(-640, 0, 0, 0);
        }
    }
}
