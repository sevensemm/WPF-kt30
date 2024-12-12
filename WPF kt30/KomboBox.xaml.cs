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

namespace WPF_kt30
{
    /// <summary>
    /// Логика взаимодействия для KomboBox.xaml
    /// </summary>
    public partial class KomboBox : Window
    {
        public KomboBox()
        {
            InitializeComponent();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            string imagePath = "C:/Users/Tsyganovsp/source/repos/Kt halava/Kt halava/image/1.jpg";
            BitmapImage bitmap = new BitmapImage(new Uri(imagePath));
            DisplayImage.Source = bitmap;
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            string imagePath = "C:/Users/Tsyganovsp/source/repos/Kt halava/Kt halava/image/2.jpg";
            BitmapImage bitmap = new BitmapImage(new Uri(imagePath));
            DisplayImage.Source = bitmap;
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            string imagePath = "C:/Users/Tsyganovsp/source/repos/Kt halava/Kt halava/image/3.jpg";
            BitmapImage bitmap = new BitmapImage(new Uri(imagePath));
            DisplayImage.Source = bitmap;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
