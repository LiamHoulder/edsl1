using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for CreateSeason.xaml
    /// </summary>
    public partial class CreateSeason : Page
    {
        public CreateSeason()
        {
            InitializeComponent();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btn_AddHoliday_Click(object sender, RoutedEventArgs e)
        {
            list_Holiday.Items.Add(new Calendar());
        }

        private void btn_GenerateSeason_Click(object sender, RoutedEventArgs e)
        {
            DateTime[] dates = new DateTime[list_Holiday.Items.Count];
            DataBase.AddSeason(StartDate.DisplayDate, dates, int.Parse(SeasonLength.Text));
            adminHomePage.adminPage.frame_ContentArea.Content = new Seasons_Draws();
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            adminHomePage.adminPage.frame_ContentArea.Content = new Seasons_Draws();
        }
    }
}
