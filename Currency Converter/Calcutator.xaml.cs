using Microsoft.Win32;
using System.Windows.Controls;

namespace Currency_Converter
{
    /// <summary>
    /// Логика взаимодействия для Calcutator.xaml
    /// </summary>
    public partial class Calcutator : Page
    {
        public Calcutator()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            Date_City dc = new Date_City();
            Date.Content = Date_City.Date;
            City.Content = Date_City.City;
        }
    }
}
