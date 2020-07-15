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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            buildMatrix(Convert.ToInt32(tbMaLength.Text));
            printMatrix();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                buildMatrix(Convert.ToInt32(tbMaLength.Text));
                txtResult.Text = "Matrix Generated."+Environment.NewLine;
                if (Convert.ToInt32(tbMaLength.Text)>8)
                {
                    txtResult.Text += "Please Note:"+Environment.NewLine+" Bigger The Length Of Matrix, Bigger The Wait Time During Search."+Environment.NewLine+"Have Patience";
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Incorrect Entry");
                txtResult.Text = "Incorrect Entry, Please Try Again.";

            }
            printMatrix();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

            searchString(txtSearch.Text.ToUpper());

        }
    }
}
