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
            if (Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run").GetValue("Currency Converter")?.ToString() != null)
                AutoRun.IsChecked = true;
            else
                AutoRun.IsChecked = false;

            if (Registry.CurrentUser.CreateSubKey(@"Software\Currency converter").GetValue("Theme")?.ToString() == "Dark")
                Theme.IsChecked = true;
            else
                Theme.IsChecked = false;
            //static Cities c = new Cities();
        }
        Cities city;
        public AppSettings()
        {
            InitializeComponent();
            city = new Cities();
        }

        private void ColorZone_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //MainWindow.MainForm.Visibility = Visibility.Hidden;
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
            } catch { }
        }

        private void Theme_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Theme.IsChecked == true)
                    Registry.CurrentUser.CreateSubKey(@"Software\Currency converter").SetValue("Theme", "Dark");
                else
                    Registry.CurrentUser.CreateSubKey(@"Software\Currency converter").SetValue("Theme", "Light");
            }
            catch { }
        }
    }
}
