using Microsoft.Win32;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MainWindow;

namespace Currency_Converter
{
    public partial class AppSettings : Page
    {
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }
        public AppSettings()
        {
            InitializeComponent();
            if (Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run").GetValue("Currency Converter")?.ToString() != null)
                AutoRun.IsChecked = true;
            else
                AutoRun.IsChecked = false;
        }

         Cities city = new Cities();
        private void ColorZone_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //MainWindow.Visibility = Visibility.Hidden;
            city.Show();
        }

            string path = "\"" + Assembly.GetExecutingAssembly().Location + "\"";

        private void AutoRun_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AutoRun.IsChecked == true)
                    Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run").SetValue("Currency Converter", path);
                else
                    Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run").DeleteValue("Currency Converter");
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Theme_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
