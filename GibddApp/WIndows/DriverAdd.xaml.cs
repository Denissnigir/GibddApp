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
    /// Логика взаимодействия для DriverAdd.xaml
    /// </summary>
    public partial class DriverAdd : Window
    {
        string pathPhoto = null;
        string namePhoto = null;
        char format1 = 'f';
        char format2 = 'f';

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
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
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
            foreach(char c in DriverEmailTB.Text)
            {
                if(c == '@')
                {
                    format1 = c;
                } else if(c == '.')
                {
                    format2 = c;
                }
            }
            if(format1 != 'f' && format2 != 'f')
            {
                driver.DriverEmail = DriverEmailTB.Text;
            }
            else
            {
                MessageBox.Show("Неверный формат Email!");
                return;
            }
            
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
                driver.DriverPhoto = photoPath;
            }
            driver.DriverDescription = DriverDescriptionTB.Text;

            Context._con.Driver.Add(driver);
            Context._con.SaveChanges();

            MessageBox.Show($"Водитель {DriverSNTB.Text} успешно добавлен!");
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
                namePhoto = pathPhoto.Split('\\').Last();
                ChoosePhotoBTN.Content = namePhoto;
            }
        }
    }
}
