using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Page
    {
        public About()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            txtAbout.Text = "Name: Kevin Valani"+Environment.NewLine+"Student ID: 991545215"+Environment.NewLine+"Project: Mid Term Project - Exam"+Environment.NewLine+"Submitted To: Dario - The Great"+Environment.NewLine+"College: Sheridan - Oakville";
        }
    }
}
