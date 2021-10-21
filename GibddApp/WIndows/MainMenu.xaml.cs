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
using System.Windows.Threading;
using GibddApp.Model;


namespace GibddApp.WIndows
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();

            var drivers = Context._con.Driver.ToList();
            DriverList.ItemsSource = drivers;
        }

       


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var idCount = Context._con.User.Count();
            for (int i = 1; i <= idCount; i++)
            {
                var user = Context._con.User.Where(p => p.UserId == i).FirstOrDefault();
                user.UserPin = null;
            }
            Context._con.SaveChanges();
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DriverAdd driverAdd = new DriverAdd();
            driverAdd.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void OpenDriver_Click(object sender, RoutedEventArgs e)
        {
            if (DriverList.SelectedItem != null)
            {
                var driverForUpdate = (Driver)DriverList.SelectedItem;
                DriverChange driverChange = new DriverChange(driverForUpdate);
                driverChange.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Сначала кликните по водителю!)");
            }
        }

        private void DeleteDriver_Click(object sender, RoutedEventArgs e)
        {
            if(DriverList.SelectedItem != null)
            {
                var driverForDelete = DriverList.SelectedItems.Cast<Driver>().ToList();
                Context._con.Driver.RemoveRange(driverForDelete);
                Context._con.SaveChanges();
                DriverList.ItemsSource = Context._con.Driver.ToList();
            }
            else
            {
                MessageBox.Show("Сначала кликните по водителю!)");
            }
        }
    }
}
