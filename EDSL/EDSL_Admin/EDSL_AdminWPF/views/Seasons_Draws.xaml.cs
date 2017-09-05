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
    /// Interaction logic for Seasons_Draws.xaml
    /// </summary>
    public partial class Seasons_Draws : Page
    {
        public Seasons_Draws()
        {
            InitializeComponent();
            DisplaSeasons();
        }

        void DisplaSeasons()
        {
            if(DataBase.Seasons.Count == 0)
            {
                SeasonsList.Opacity = 0;
                NoSeasons_msg.Opacity = 100;
            }
            else
            {
                foreach(Season s in DataBase.Seasons)
                {
                    string x = s.StartDate.ToString() + ",    " + s.Length.ToString() + ",       Num of holidays: " + s.Holidays.Length.ToString();
                    SeasonsList.Items.Add(x);
                }
            }
        }

        private void btn_AddSeason_Click(object sender, RoutedEventArgs e)
        {
            adminHomePage.adminPage.frame_ContentArea.Content = new CreateSeason();
        }
    }
}
