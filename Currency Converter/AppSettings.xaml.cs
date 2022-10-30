using Microsoft.Win32;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MainWindow;
using System.Windows.Media;
using System.Threading.Tasks;

namespace Currency_Converter
{
    public partial class AppSettings : Page
    {
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
        }
        Cities city;
        public AppSettings()
        {
            Reg();
            city = new Cities();
            InitializeComponent();
        }

        private void ColorZone_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //MW.Visibility = Visibility.Hidden;
            city.Show();
        }
        void Reg()
        {
            try
            {
                if (Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run").GetValue("Currency Converter")?.ToString() != null)
                    AutoRun.IsChecked = true;
                else
                    AutoRun.IsChecked = false;
            } catch { }
            try
            {
                if (Registry.CurrentUser.CreateSubKey(@"Software\Currency converter").GetValue("Theme")?.ToString() == "Dark")
                    Theme.IsChecked = true;
                else
                    Theme.IsChecked = false;
            } catch { }
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
                {
                    Registry.CurrentUser.CreateSubKey(@"Software\Currency converter").SetValue("Theme", "Dark");
                    //MainWindow.MainForm = new SolidColorBrush(Color.FromRgb(50, 50, 50));
                }
                else
                {
                    Registry.CurrentUser.CreateSubKey(@"Software\Currency converter").SetValue("Theme", "Light");
                }
            }
            catch { }
        }
    }
}
