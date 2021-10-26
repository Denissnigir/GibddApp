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
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        TimeSpan dispatcherTimeCounter;
        TimeSpan timeLimit = new TimeSpan(0, 1, 0);

        public MainMenu()
        {
            InitializeComponent();

            var drivers = Context._con.Driver.ToList();
            DriverList.ItemsSource = drivers;

            dispatcherTimeCounter = new TimeSpan(0, 0, 0);
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            dispatcherTimer.Tick += new EventHandler(TimerTick);
            dispatcherTimer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            dispatcherTimeCounter += new TimeSpan(0, 0, 1);

            if (dispatcherTimeCounter >= new TimeSpan(0, 1, 0))
            {
                dispatcherTimer.Stop();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
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
            dispatcherTimer.Stop();
            DriverAdd driverAdd = new DriverAdd();
            driverAdd.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void OpenDriver_Click(object sender, RoutedEventArgs e)
        {
            if (DriverList.SelectedItem != null)
            {
                dispatcherTimer.Stop();
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
            if (DriverList.SelectedItem != null)
            {
                var driverForDelete = DriverList.SelectedItems.Cast<Driver>().ToList();
                Context._con.Driver.RemoveRange(driverForDelete);
                Context._con.SaveChanges();
                DriverList.ItemsSource = Context._con.Driver.ToList();
                MessageBox.Show("Данные о водителе удалены и занесены в архив.");
            }
            else
            {
                MessageBox.Show("Сначала кликните по водителю!)");
            }
        }

        private void DriverList_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            dispatcherTimeCounter = new TimeSpan(0, 0, 0);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainMenuLicence mainMenuLicence = new MainMenuLicence();
            mainMenuLicence.Show();
            this.Close();
        }
    }
}
