using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
        Season x = new Season();

        public Seasons_Draws()
        {
            InitializeComponent();
            DisplaSeasons();
        }

        void DisplaSeasons()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://edslapi9272.azurewebsites.net");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("/api/Seasons").Result;

            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsAsync<IEnumerable<Season>>().Result;

                if (content.Count() == 0)
                {
                    SeasonsList.Opacity = 0;
                    NoSeasons_msg.Opacity = 100;
                }
                else
                {
                    btn_AddSeason.IsEnabled = false;
                    SeasonsList.ItemsSource = content;
                    x = content.ElementAt(0);
                    btn_Edit.IsEnabled = true;

                }
            }
            else
            {
                SeasonsList.Opacity = 0;
                NoSeasons_msg.Opacity = 100;
                NoSeasons_msg.Content = "Could not connect to api";
            }
        }

        private void btn_AddSeason_Click(object sender, RoutedEventArgs e)
        {
            adminHomePage.adminPage.frame_ContentArea.Content = new CreateSeason();
        }

        private void SeasonsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            adminHomePage.adminPage.frame_ContentArea.Content = new CreateSeason(x);
        }
    }
}
