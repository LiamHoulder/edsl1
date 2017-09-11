using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
        bool isEdit = false;

        public CreateSeason()
        {
            InitializeComponent();
        }

        public CreateSeason(Season x)
        {
            InitializeComponent();
            StartDate.DisplayDate = new DateTime(2017, 9, 18);
            SeasonLength.Text = x.numRounds.ToString();
            isEdit = true;
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

        private void btn_GenerateSeason_Click(object sender, RoutedEventArgs e) //HOOK UP TO API
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://edslapi9272.azurewebsites.net");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if (!isEdit)
            {
                var newSeason = new Season();
                newSeason.startDate = 2017;//int.Parse(StartDate.ToString());

                DateTime[] dates = new DateTime[list_Holiday.Items.Count];
                string breaks = "";
                foreach (DateTime s in dates)
                {
                    breaks += s.Date.ToString();
                    breaks += ", ";
                }
                newSeason.nonPlayWeeks = "NONE";
                newSeason.seasonYear = 2017;//int.Parse(StartDate.DisplayDate.Year.ToString());
                newSeason.numRounds = int.Parse(SeasonLength.Text.ToString());

                var response = client.PostAsJsonAsync("/api/Seasons", newSeason).Result;
            }
            else
            {
                var newSeason = new Season();
                newSeason.startDate = 2017;//int.Parse(StartDate.ToString());

                DateTime[] dates = new DateTime[list_Holiday.Items.Count];
                string breaks = "";
                foreach (DateTime s in dates)
                {
                    breaks += s.Date.ToString();
                    breaks += ", ";
                }
                newSeason.nonPlayWeeks = "NONE";
                newSeason.seasonYear = 2017;//int.Parse(StartDate.DisplayDate.Year.ToString());
                newSeason.numRounds = int.Parse(SeasonLength.Text.ToString());

                var response = client.PutAsJsonAsync("/api/Seasons/0", newSeason).Result;
            }

            //DataBase.AddSeason(StartDate.DisplayDate, dates, int.Parse(SeasonLength.Text));
            adminHomePage.adminPage.frame_ContentArea.Content = new Seasons_Draws();
        }
    }
}
