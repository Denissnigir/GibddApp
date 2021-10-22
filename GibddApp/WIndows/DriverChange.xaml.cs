using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;

namespace GibddApp.WIndows
{
    /// <summary>
    /// Логика взаимодействия для DriverChange.xaml
    /// </summary>
    public partial class DriverChange : Window
    {
        Driver driverData;
        string pathPhoto = null;
        string namePhoto = null;

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
            if(driverData.DriverPhoto == null)
            {
                ChoosePhotoBTN.Content = "Выберите фото";
            }
            else
            {
                string prevPhotoPath = driverData.DriverPhoto;
                string prevPhotoName = prevPhotoPath.Split('\\')[prevPhotoPath.Split('\\').Length - 1];
                ChoosePhotoBTN.Content = prevPhotoName;
            }
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
            if(TownListCB.SelectedIndex == -1)
            {
                driverData.DriverTownId = null;
            }
            else
            {
                driverData.DriverTownId = TownListCB.SelectedIndex + 1;
            }
            
            driverData.DriverAddress = DriverAddressTB.Text;
            if (TownLifeListCB.SelectedIndex == -1)
            {
                driverData.DriverTownLifeId = null;
            }
            else
            {
                driverData.DriverTownLifeId = TownLifeListCB.SelectedIndex + 1;
            }
            driverData.DriverAddressLife = DriverAddressLifeTB.Text;
            if(CompanyCB.SelectedIndex == -1)
            {
                driverData.DriverCompanyId = null;
            }
            else
            {
                driverData.DriverCompanyId = CompanyCB.SelectedIndex + 1;
            }
            if(JobCB.SelectedIndex == -1)
            {
                driverData.DriverJobId = null;
            }
            else
            {
                driverData.DriverJobId = JobCB.SelectedIndex + 1;
            }
            driverData.DriverPhone = DriverPhoneTB.Text;
            driverData.DriverEmail = DriverEmailTB.Text;
            if (pathPhoto != null)
            {
                string photoPath = $@"\photo\{namePhoto}";
                try
                {
                    File.Copy(pathPhoto, $@"..\..{photoPath}");
                }
                catch
                {

                }
                driverData.DriverPhoto = photoPath;
            }
            driverData.DriverDescription = DriverDescriptionTB.Text;

            Context._con.SaveChanges();
            MessageBox.Show("Водитель успешно изменён!");
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void ChoosePhotoBTN_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if ((bool)openFileDialog.ShowDialog())
            {
                pathPhoto = openFileDialog.FileName;

                if (pathPhoto != null)
                {
                    namePhoto = pathPhoto.Split('\\').Last();

                    ChoosePhotoBTN.Content = $"{namePhoto}";
                }
            }
        }
    }
}
