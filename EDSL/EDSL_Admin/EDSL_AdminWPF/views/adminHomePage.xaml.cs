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

namespace EDSL_AdminWPF.views
{
    /// <summary>
    /// Interaction logic for adminHomePage.xaml
    /// </summary>
    public partial class adminHomePage : Page
    {
        public static adminHomePage adminPage;

        public adminHomePage()
        {
            InitializeComponent();
            adminPage = this;
        }

        //View round results button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frame_ContentArea.Navigate(new RoundResults());
        }

        private void button_seasons_draws_Click(object sender, RoutedEventArgs e)
        {
            frame_ContentArea.Navigate(new Seasons_Draws());
        }

        private void btn_EDSL_Admin_Click(object sender, RoutedEventArgs e)
        {
            frame_ContentArea.Navigate(new Page());
        }
    }
}
