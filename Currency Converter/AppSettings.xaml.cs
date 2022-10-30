using Microsoft.Win32;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Currency_Converter
{
    public partial class AppSettings : Page
    {
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
            city.Show();
            //MainWindow.Visibility = Visibility.Hidden;
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
    }
}
