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
    /// Логика взаимодействия для PinWindow.xaml
    /// </summary>
    public partial class PinWindow : Window
    {
        public User userData;
        public PinWindow(User user)
        {
            InitializeComponent();
            userData = user;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(userData.UserPin == PinTB.Text)
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Close();
            } else if(PinTB.Text == "")
            {
                MessageBox.Show("Введите PIN-код!");
            }
            else
            {
                MessageBox.Show("Неверно!");
            }
        }
    }
}
