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
using EDSL_AdminWPF.views;

namespace EDSL_AdminWPF
{
    /// <summary>
    /// Interaction logic for index.xaml
    /// </summary>
    public partial class index : Page
    {
        public index()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_Password.Password == "password" && textBox_username.Text == "Admin")
            {
                WindowController.mainWindow.setPage(new adminHomePage());
            }
            else
            {
                text_incorrect.Opacity = 100;
            }
        }

        private void textBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if(Key.Enter == e.Key)
            {
                Button_Click(sender, e);
            }
        }
    }
}
