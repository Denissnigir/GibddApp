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
using System.Windows.Shapes;
using GibddApp.Model;

namespace GibddApp.WIndows
{
    /// <summary>
    /// Логика взаимодействия для MainMenuLicence.xaml
    /// </summary>
    public partial class MainMenuLicence : Window
    {
        public MainMenuLicence()
        {
            InitializeComponent();

            LicenceList.ItemsSource = Context._con.Licence.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var licenceData = (Licence)LicenceList.SelectedItem;
            LicencePrint licence = new LicencePrint(licenceData);
            licence.Show();
        }
    }
}
