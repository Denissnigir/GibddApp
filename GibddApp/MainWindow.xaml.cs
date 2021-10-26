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
using GibddApp.WIndows;
using GibddApp.Model;
using System.IO;

namespace GibddApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        string num1;
        string num2;
        string num3;
        string num4;
        public static string curPin;
        public List<User> userData = new List<User>();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var idCount = Context._con.User.Count();
            for(int i = 1; i <= idCount; i++)
            {
                var user = Context._con.User.Where(p => p.UserId == i).FirstOrDefault();
                user.UserPin = null;
            }
            Context._con.SaveChanges();
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var user = Context._con.User.Where(i => i.UserLogin == LoginTB.Text && i.UserPassword == PasswordTB.Text).FirstOrDefault();

            if(user != null && user.UserPin == null)
            {
                num1 = Convert.ToString(random.Next(0, 9));
                num2 = Convert.ToString(random.Next(0, 9));
                num3 = Convert.ToString(random.Next(0, 9));
                num4 = Convert.ToString(random.Next(0, 9));
                curPin = num1 + num2 + num3 + num4;

                user.UserPin = curPin;
                Context._con.SaveChanges();

                MessageBox.Show($"Ваш PIN-код: {curPin}");

                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();
            }
            else if(user != null && user.UserPin != null)
            {
                PinWindow pinWindow = new PinWindow(user);
                pinWindow.Show();
            } else if(user == null)
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }

        
    }
}
