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

namespace KevinValaniMidTerm
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new Home();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            makeActive(btnHome);
            mainFrame.Content = new Home();

        }

        private void btnHowTo_Click(object sender, RoutedEventArgs e)
        {
            makeActive(btnHowTo);
            mainFrame.Content = new HowTo();
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            makeActive(btnAbout);
            mainFrame.Content = new About();
        }

        private void makeActive(Button btn)
        {

            btnHowTo.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF0E0E4B"));
            btnAbout.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF0E0E4B"));
            btnHome.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF0E0E4B")); ;
            btn.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF444466"));
        }
    }
}
