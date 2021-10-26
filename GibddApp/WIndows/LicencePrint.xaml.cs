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

namespace GibddApp.WIndows
{
    /// <summary>
    /// Логика взаимодействия для LicencePrint.xaml
    /// </summary>
    public partial class LicencePrint : Window
    {
        ImageSourceConverter ImageSourceConverter = new ImageSourceConverter();
        public LicencePrint(Licence licence)
        {
            InitializeComponent();
            serial.Text = licence.LicenceSeries.ToString();

            MemoryStream ms = new MemoryStream(licence.image);
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = ms;
            bitmapImage.EndInit();


            Photo.Source = bitmapImage;

        }
    }
}
