using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Currency_Converter
{
    /// <summary>
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
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

        public int siss;
        void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Page_Loader.Navigate(MW.Page_AppSettings);
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
        }        
        private void TUSD_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("USD");
        }

        private void TRUB_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("RUB");
        }
        private void TRUB_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("RUB");
        }

        private void TEUR_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("EUR");
        }
        private void TEUR_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("EUR");
        }

        private void TUAH_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("UAH");
        }
        private void TUAH_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("UAH");
        }

        private void TGBP_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("GBP");
        }

        private void TGBP_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("GBP");
        }

        private void TCNY_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("CNY");
        }
        private void TCNY_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("CNY");
        }

        private void TJPY_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("JPY");
        }
        private void TJPY_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("JPY");
        }

        private void TNOK_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("NOK");
        }
        private void TNOK_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("NOK");
        }

        private void TCAD_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("CAD");
        }
        private void TCAD_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("CAD");
        }

        private void TPLN_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("PLN");
        }
        private void TPLN_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("PLN");
        }

        private void TSEK_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("SEK");
        }
        private void TSEK_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("SEK");
        }

        private void TCHF_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("CHF");
        }
        private void TCHF_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("CHF");
        }

        private void TCZK_Checked(object sender, RoutedEventArgs e)
        {
            Currency_Activate("CZK");
        }
        private void TCZK_Unchecked(object sender, RoutedEventArgs e)
        {
            Currency_Deactivate("CZK");
        }
    }
}
