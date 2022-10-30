using System;
using System.Windows;

namespace Currency_Converter
{
    /// <summary>
    /// Логика взаимодействия для Cities.xaml
    /// </summary>
    public partial class Cities : Window
    {
        public Cities()
        {
            InitializeComponent();
        }           
        private void Border_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Hide();
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            GC.Collect();
        }

        private void Change_City_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Hide();
            Date_City.City = "Жлобин";
        }
    }
}
