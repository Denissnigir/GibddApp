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
using System.Drawing.Imaging;
using GibddApp.Model;
using System.Printing;

namespace GibddApp.WIndows
{
    /// <summary>
    /// Логика взаимодействия для LicencePrint.xaml
    /// </summary>
    public partial class LicencePrint : Window
    {
        public LicencePrint(Licence licence)
        {
            InitializeComponent();

            secondName.Text = licence.Driver.DriverSecondName.ToString();
            firstName.Text = licence.Driver.DriverFirstName.ToString();
            birthdate.DataContext = licence.Driver;
            if (licence.Driver.DriverTownId != null)
            {
                town.Text = licence.Driver.Town.TownName.ToString();
            }
            else
            {
                town.Text = "Нет города";
            }

            licenceDate.DataContext = licence;
            licenceExpireDate.DataContext = licence;
            if (licence.Driver.DriverOrgan != null)
            {
                organ.Text = licence.Driver.DriverOrgan.ToString();
            }
            else
            {
                organ.Text = "Никакой!";
            }
            number.Text = licence.LicenceNumber.ToString();
            if (licence.Driver.DriverTownLifeId != null)
            {
                townLife.Text = licence.Driver.Town1.TownName.ToString();
            }
            else
            {
                town.Text = "Нет города";
            }
            categories.Text = licence.Category.ToString();

            MemoryStream ms = new MemoryStream(licence.image);
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = ms;
            bitmapImage.EndInit();


            Photo.Source = bitmapImage;

            PrintDialog printDialog = new PrintDialog();
            if((bool)printDialog.ShowDialog())
            {
                PrintTicket print = printDialog.PrintTicket;
                print.PageOrientation = PageOrientation.Landscape;
                printDialog.PrintTicket = print;
                printDialog.PrintVisual((Visual)printPage, "Desc");
            }
        }

    }
}
