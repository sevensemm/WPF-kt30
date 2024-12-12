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
    /// Логика взаимодействия для Stack_panale.xaml
    /// </summary>
    public partial class Stack_panale : Window
    {
        public Stack_panale()
        {
            InitializeComponent();
        }

        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {
            TreeViewItem tree = (TreeViewItem)sender;
            MessageBox.Show("Вы выбрали: "+ tree.Header.ToString(), "Выбор БД", MessageBoxButton.OK, MessageBoxImage.Hand);

        }

        private void Date_picker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DatePicker date = (DatePicker)sender;
            MessageBox.Show("Концерт лил пипа " + date.SelectedDate.Value.ToShortDateString() + " недоступен(((");
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            Calendar cal = (Calendar)sender;
            MessageBox.Show("Концерт лил пипа " + cal.SelectedDate.Value.ToShortDateString() + " недоступен(((");
        }
    }
}
