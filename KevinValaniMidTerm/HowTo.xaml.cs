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
    /// Interaction logic for HowTo.xaml
    /// </summary>
    public partial class HowTo : Page
    {
        public HowTo()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            txtHelp.Text = "1. On Game Page, Please Manually Enter Matrix Length. e.g. 6"+Environment.NewLine;
            txtHelp.Text += "2. Once The Grid Is Loaded, Please Enter String To Search And Press Search Button."+Environment.NewLine;
            txtHelp.Text += "3. It Might Take Few Seconds To Load If Length Of Matrix Is More."+Environment.NewLine;
            txtHelp.Text += "That's All. It is Pretty Easy."+Environment.NewLine+ Environment.NewLine;
            txtHelp.Text += "PLEASE NOTE: "+Environment.NewLine;
            txtHelp.Text += "1. Your Search String Is Automatically Converted To All Uppercase"+Environment.NewLine+"2. Obviously, Ai On Top Left Doesn't Mean Artificial Intelligence. It Is Because, It Looks Good.";
            txtHelp.Text += Environment.NewLine;
        }
    }
}
