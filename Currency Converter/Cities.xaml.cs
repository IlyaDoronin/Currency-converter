using Microsoft.Win32;
using System;
using System.Windows;

namespace Currency_Converter
{
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
            string town = "Старые дороги";
            MainWindow.Page_Cources.Update(town);
            MainWindow.Page_Calcutator.Update(town);
            Registry.CurrentUser.CreateSubKey(@"Software\Currency converter").SetValue("City", town);
        }
    }
}
