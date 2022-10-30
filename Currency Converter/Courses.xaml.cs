using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Currency_Converter
{
    public partial class Courses
    {
        public Courses()
        {
            InitializeComponent();
            Currency_Check();
            Date.Content = (DateTime.Now.Date).ToString("dd.MM.yyyy");
            Update(Registry.CurrentUser.CreateSubKey(@"Software\Currency converter").GetValue("City").ToString());
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
        }
        public static Parse p = new Parse("Минск");
        async public void Update(string town = "Минск")
        {
            //Parallel.Invoke(() =>
            //{
            //});
            while (true)
            {
                DataContext = p;
                await Task.Delay(5000);
            }
        }
        string currency_path = @"Software\Currency converter\Currency";
        public void Currency_Check()
        {
            try
            {
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("USD")?.ToString() == "False")
                    Grid_0.Visibility = Visibility.Collapsed;
                else
                    Grid_0.Visibility = Visibility.Visible;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("RUB")?.ToString() == "False")
                    Grid_1.Visibility = Visibility.Collapsed;
                else
                    Grid_1.Visibility = Visibility.Visible;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("EUR")?.ToString() == "False")
                    Grid_2.Visibility = Visibility.Collapsed;
                else
                    Grid_2.Visibility = Visibility.Visible;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("UAH")?.ToString() == "False")
                    Grid_3.Visibility = Visibility.Collapsed;
                else
                    Grid_3.Visibility = Visibility.Visible;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("GBP")?.ToString() == "False")
                    Grid_4.Visibility = Visibility.Collapsed;
                else
                    Grid_4.Visibility = Visibility.Visible;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("CNY")?.ToString() == "False")
                    Grid_5.Visibility = Visibility.Collapsed;
                else
                    Grid_5.Visibility = Visibility.Visible;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("JPY")?.ToString() == "False")
                    Grid_6.Visibility = Visibility.Collapsed;
                else
                    Grid_6.Visibility = Visibility.Visible;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("NOK")?.ToString() == "False")
                    Grid_7.Visibility = Visibility.Collapsed;
                else
                    Grid_7.Visibility = Visibility.Visible;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("CAD")?.ToString() == "False")
                    Grid_8.Visibility = Visibility.Collapsed;
                else
                    Grid_8.Visibility = Visibility.Visible;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("PLN")?.ToString() == "False")
                    Grid_9.Visibility = Visibility.Collapsed;
                else
                    Grid_9.Visibility = Visibility.Visible;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("SEK")?.ToString() == "False")
                    Grid_10.Visibility = Visibility.Collapsed;
                else
                    Grid_10.Visibility = Visibility.Visible;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("CHF")?.ToString() == "False")
                    Grid_11.Visibility = Visibility.Collapsed;
                else
                    Grid_11.Visibility = Visibility.Visible;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("CZK")?.ToString() == "False")
                    Grid_12.Visibility = Visibility.Collapsed;
                else
                    Grid_12.Visibility = Visibility.Visible;
            }
            catch { }
        }
    }
}
