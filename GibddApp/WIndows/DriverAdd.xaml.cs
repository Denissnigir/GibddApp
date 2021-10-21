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
    /// Логика взаимодействия для DriverAdd.xaml
    /// </summary>
    public partial class DriverAdd : Window
    {
        public DriverAdd()
        {
            InitializeComponent();

            TownListCB.ItemsSource = Context._con.Town.ToList();
            TownLifeListCB.ItemsSource = Context._con.Town.ToList();
            CompanyCB.ItemsSource = Context._con.Company.ToList();
            JobCB.ItemsSource = Context._con.JobList.ToList();

            int countId = Context._con.Driver.Count();
            countId++;
            IdCounterTB.Text = Convert.ToString(countId);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Driver driver = new Driver();
            driver.DriverId = Convert.ToInt32(IdCounterTB.Text);
            driver.DriverFirstName = DriverFNTB.Text;
            driver.DriverSecondName = DriverSNTB.Text;
            driver.DriverPassportSerial = DriverPassSerialTB.Text;
            driver.DriverPassportNumber = DriverPassNumberTB.Text;
            driver.DriverTownId = TownListCB.SelectedIndex + 1;
            driver.DriverAddress = DriverAddressTB.Text;
            driver.DriverTownLifeId = TownLifeListCB.SelectedIndex + 1;
            driver.DriverAddressLife = DriverAddressLifeTB.Text;
            driver.DriverCompanyId = CompanyCB.SelectedIndex + 1;
            driver.DriverJobId = JobCB.SelectedIndex + 1;
            driver.DriverPhone = DriverPhoneTB.Text;
            driver.DriverEmail = DriverEmailTB.Text;
            driver.DriverDescription = DriverDescriptionTB.Text;

            Context._con.Driver.Add(driver);
            Context._con.SaveChanges();

            MessageBox.Show($"Водитель {DriverSNTB.Text} успешно добавлен!");
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }
    }
}
