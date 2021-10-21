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
    /// Логика взаимодействия для DriverChange.xaml
    /// </summary>
    public partial class DriverChange : Window
    {
        Driver driverData;

        public DriverChange(Driver driver)
        {
            InitializeComponent();
            driverData = driver;
            TownListCB.ItemsSource = Context._con.Town.ToList();
            TownLifeListCB.ItemsSource = Context._con.Town.ToList();
            CompanyCB.ItemsSource = Context._con.Company.ToList();
            JobCB.ItemsSource = Context._con.JobList.ToList();


            IdCounterTB.Text = Convert.ToString(driverData.DriverId);
            DriverFNTB.Text = driverData.DriverFirstName;
            DriverSNTB.Text = driverData.DriverSecondName;
            DriverPassSerialTB.Text = driverData.DriverPassportSerial;
            DriverPassNumberTB.Text = driverData.DriverPassportNumber;
            
            if (driverData.DriverTownId == null)
            {
                TownListCB.SelectedIndex = -1;
            }
            else
            {
                TownListCB.SelectedIndex = (int)driverData.DriverTownId - 1;
            }
            DriverAddressTB.Text = driverData.DriverAddress;
            
            if (driverData.DriverTownLifeId == null)
            {
                TownLifeListCB.SelectedIndex = -1;
            }
            else
            {
                TownLifeListCB.SelectedIndex = (int)driverData.DriverTownLifeId - 1;
            }
            DriverAddressLifeTB.Text = driverData.DriverAddressLife;
            
            if (driverData.DriverCompanyId == null)
            {
                CompanyCB.SelectedIndex = -1;
            }
            else
            {
                CompanyCB.SelectedIndex = (int)driverData.DriverCompanyId - 1;
            }
            
            if(driverData.DriverJobId == null)
            {
                JobCB.SelectedIndex = -1;
            }
            else
            {
                JobCB.SelectedIndex = (int)driverData.DriverJobId - 1;

            }
            DriverPhoneTB.Text = driverData.DriverPhone;
            DriverEmailTB.Text = driverData.DriverEmail;
            DriverDescriptionTB.Text = driverData.DriverDescription;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            driverData.DriverId = Convert.ToInt32(IdCounterTB.Text);
            driverData.DriverFirstName = DriverFNTB.Text;
            driverData.DriverSecondName = DriverSNTB.Text;
            driverData.DriverPassportSerial = DriverPassSerialTB.Text;
            driverData.DriverPassportNumber = DriverPassNumberTB.Text;
            driverData.DriverTownId = TownListCB.SelectedIndex + 1;
            driverData.DriverAddress = DriverAddressTB.Text;
            driverData.DriverTownLifeId = TownLifeListCB.SelectedIndex + 1;
            driverData.DriverAddressLife = DriverAddressLifeTB.Text;
            driverData.DriverCompanyId = CompanyCB.SelectedIndex + 1;
            driverData.DriverJobId = JobCB.SelectedIndex + 1;
            driverData.DriverPhone = DriverPhoneTB.Text;
            driverData.DriverEmail = DriverEmailTB.Text;
            driverData.DriverDescription = DriverDescriptionTB.Text;

            Context._con.SaveChanges();
            MessageBox.Show("Водитель успешно изменён!");
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }
    }
}
