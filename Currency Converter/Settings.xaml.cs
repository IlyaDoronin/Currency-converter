using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Currency_Converter
{
    public partial class Settings : Page
    {
        public byte Currency_Count;
        string path = @"Software\Currency converter";
        string currency_path = @"Software\Currency converter\Currency";

        public Settings()
        {
            InitializeComponent();
            Currency_Check();
        }
        void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (UIElement toggle in Content.Children)
            {
                if ((toggle as ToggleButton) != null)
                {
                    (toggle as ToggleButton).IsChecked = true;
                }
            }
        }

        void Button_Click_2(object sender, RoutedEventArgs e)
        {
            foreach (UIElement toggle in Content.Children)
            {
                if ((toggle as ToggleButton) != null)
                {
                    (toggle as ToggleButton).IsChecked = false;
                }
            }
        }

        void Currency_Check()
        {
            try
            {
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("USD")?.ToString() == "False")
                    TUSD.IsChecked = false;
                else
                    TUSD.IsChecked = true;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("RUB")?.ToString() == "False")
                    TRUB.IsChecked = false;
                else
                    TRUB.IsChecked = true;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("EUR")?.ToString() == "False")
                    TEUR.IsChecked = false;
                else
                    TEUR.IsChecked = true;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("UAH")?.ToString() == "False")
                    TUAH.IsChecked = false;
                else
                    TUAH.IsChecked = true;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("GBP")?.ToString() == "False")
                    TGBP.IsChecked = false;
                else
                    TGBP.IsChecked = true;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("CNY")?.ToString() == "False")
                    TCNY.IsChecked = false;
                else
                    TCNY.IsChecked = true;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("JPY")?.ToString() == "False")
                    TJPY.IsChecked = false;
                else
                    TJPY.IsChecked = true;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("NOK")?.ToString() == "False")
                    TNOK.IsChecked = false;
                else
                    TNOK.IsChecked = true;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("CAD")?.ToString() == "False")
                    TCAD.IsChecked = false;
                else
                    TCAD.IsChecked = true;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("PLN")?.ToString() == "False")
                    TPLN.IsChecked = false;
                else
                    TPLN.IsChecked = true;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("SEK")?.ToString() == "False")
                    TSEK.IsChecked = false;
                else
                    TSEK.IsChecked = true;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("CHF")?.ToString() == "False")
                    TCHF.IsChecked = false;
                else
                    TCHF.IsChecked = true;
                if (Registry.CurrentUser.CreateSubKey(currency_path).GetValue("CZK")?.ToString() == "False")
                    TCZK.IsChecked = false;
                else
                    TCZK.IsChecked = true;
            } catch { }
        }
        void Currency_Activate(string Currency)
        {
            try
            {
                Registry.CurrentUser.CreateSubKey(currency_path).SetValue(Currency, "True");
            }
            catch { }
        }
        void Currency_Deactivate(string Currency)
        {
            try
            {
                Registry.CurrentUser.CreateSubKey(currency_path).SetValue(Currency, "False");
            }
            catch { }
        }
        private void TUSD_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("USD");
            MainWindow.Page_Cources.Grid_0.Visibility = Visibility.Visible;
        }
        private void TUSD_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("USD");
            MainWindow.Page_Cources.Grid_0.Visibility = Visibility.Collapsed;
        }
        
        private void TRUB_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("RUB");
            MainWindow.Page_Cources.Grid_1.Visibility = Visibility.Visible;
        }
        private void TRUB_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("RUB");
            MainWindow.Page_Cources.Grid_1.Visibility = Visibility.Collapsed;
        }

        private void TEUR_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("EUR");
            MainWindow.Page_Cources.Grid_2.Visibility = Visibility.Visible;
        }
        private void TEUR_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("EUR");
            MainWindow.Page_Cources.Grid_2.Visibility = Visibility.Collapsed;
        }

        private void TUAH_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("UAH");
            MainWindow.Page_Cources.Grid_3.Visibility = Visibility.Visible;
        }
        private void TUAH_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("UAH");
            MainWindow.Page_Cources.Grid_3.Visibility = Visibility.Collapsed;
        }

        private void TGBP_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("GBP");
            MainWindow.Page_Cources.Grid_4.Visibility = Visibility.Visible;
        }

        private void TGBP_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("GBP");
            MainWindow.Page_Cources.Grid_4.Visibility = Visibility.Collapsed;
        }

        private void TCNY_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("CNY");
            MainWindow.Page_Cources.Grid_5.Visibility = Visibility.Visible;
        }
        private void TCNY_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("CNY");
            MainWindow.Page_Cources.Grid_5.Visibility = Visibility.Collapsed;
        }

        private void TJPY_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("JPY");
            MainWindow.Page_Cources.Grid_6.Visibility = Visibility.Visible;
        }
        private void TJPY_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("JPY");
            MainWindow.Page_Cources.Grid_6.Visibility = Visibility.Collapsed;
        }

        private void TNOK_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("NOK");
            MainWindow.Page_Cources.Grid_7.Visibility = Visibility.Visible;
        }
        private void TNOK_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("NOK");
            MainWindow.Page_Cources.Grid_7.Visibility = Visibility.Collapsed;
        }

        private void TCAD_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("CAD");
            MainWindow.Page_Cources.Grid_8.Visibility = Visibility.Visible;
        }
        private void TCAD_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("CAD");
            MainWindow.Page_Cources.Grid_8.Visibility = Visibility.Collapsed;
        }

        private void TPLN_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("PLN");
            MainWindow.Page_Cources.Grid_9.Visibility = Visibility.Visible;
        }
        private void TPLN_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("PLN");
            MainWindow.Page_Cources.Grid_9.Visibility = Visibility.Collapsed;
        }

        private void TSEK_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("SEK");
            MainWindow.Page_Cources.Grid_10.Visibility = Visibility.Visible;
        }
        private void TSEK_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("SEK");
            MainWindow.Page_Cources.Grid_10.Visibility = Visibility.Collapsed;
        }

        private void TCHF_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("CHF");
            MainWindow.Page_Cources.Grid_11.Visibility = Visibility.Visible;
        }
        private void TCHF_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("CHF");
            MainWindow.Page_Cources.Grid_11.Visibility = Visibility.Collapsed;
        }

        private void TCZK_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("CZK");
            MainWindow.Page_Cources.Grid_12.Visibility = Visibility.Visible;
        }
        private void TCZK_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("CZK");
            MainWindow.Page_Cources.Grid_12.Visibility = Visibility.Collapsed;
        }
    }
}
