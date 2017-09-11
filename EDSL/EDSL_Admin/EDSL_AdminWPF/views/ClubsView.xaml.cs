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
using EDSL_AdminWPF;

namespace EDSL_AdminWPF.views
{
    /// <summary>
    /// Interaction logic for ClubsView.xaml
    /// </summary>
    public partial class ClubsView : Page
    {
        public ClubsView()
        {
            InitializeComponent();
            initAsync();
        }

        void initAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://edslapi9272.azurewebsites.net");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("/api/Clubs").Result;

            if (response.IsSuccessStatusCode)
            {

                var content = response.Content.ReadAsAsync<IEnumerable<Club>>().Result;

                list_Clubs.ItemsSource = content;
            }
        }

        private void list_Clubs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
