using Microsoft.Win32;
using System;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Currency_Converter
{
    public partial class Calcutator : Page
    {
        static double usd = 0;
        static double rub = 0;
        static double eur = 0;
        static double uah = 0;
        public Calcutator()
        {
            InitializeComponent();          
            Date.Content = (DateTime.Now.Date).ToString("dd.MM.yyyy");
            Content = GetContent();
            usd = Reg("\"Доллар США\",\"Cur_OfficialRate\":(.*?)}");
            rub = Reg("\"Российских рублей\",\"Cur_OfficialRate\":(.*?)}") / 100;
            eur = Reg("\"Евро\",\"Cur_OfficialRate\":(.*?)}");
            uah = Reg("\"Гривен\",\"Cur_OfficialRate\":(.*?)}") / 100;
        }
        
        void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Update();
        }

        Parse pr = Courses.p;
        async public void Update(string town = "Минск")
        {
            Parallel.Invoke(() =>
            {
                while (true)
                {
                    DataContext = pr;
                }
            });
        }
        void Correct(TextBox Input)
        {
            if (Regex.IsMatch(Input.Text, "[^0-9-,]"))
            {
                Input.Text = Input.Text.Remove(Input.Text.Length - 1);
                Input.SelectionStart = Input.Text.Length;
            }
        }
        static string Content = "";
        static string GetContent()
        {
            string line = "";
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = Encoding.UTF8;
                    line = wc.DownloadString("https://www.nbrb.by/api/exrates/rates?periodicity=0");
                }
            }
            catch { }
            return line;
        }
        static double Reg(string expression)
        {
            string result = "";
            Match value = Regex.Match(Content, expression);
            result = value.Groups[1].Value;
            if (result == null)
                result = "0";
            return Convert.ToDouble(result.Replace(".",","));
        }
        void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            Correct(Input);
        }

        void Output_TextChanged(object sender, TextChangedEventArgs e)
        {
            Correct(Output);
        }
        void convert(double value = 0, bool BYN = true, bool USD = true, bool RUB = true, bool EUR = true, bool UAH = true)
        {
            try
            {
                double content = Convert.ToDouble(value);
                if (BYN == true)
                    BYN_Field.Text = value.ToString("F" + 4);
                if (USD == true)
                    USD_Field.Text = (content / usd).ToString("F" + 4);
                if (RUB == true)
                    RUB_Field.Text = (content / rub).ToString("F" + 4);
                if (EUR == true)
                    EUR_Field.Text = (content / eur).ToString("F" + 4);
                if (UAH == true)
                    UAH_Field.Text = (content / uah).ToString("F" + 4);
            }
            catch { }
        }
        void BYN_Field_TextChanged(object sender, TextChangedEventArgs e)// Конвертация из поля для BYN
        {
            Correct(BYN_Field);
            if(byn_activate != false)
            {
                if(BYN_Field.Text != "")
                    convert(Convert.ToDouble(BYN_Field.Text), false);
            }
        }

        void USD_Field_TextChanged(object sender, TextChangedEventArgs e) // Конвертация из поля для USD
        {
            Correct(USD_Field);
            if(usd_activate != false)
            {
                if (USD_Field.Text != "")
                    convert(Convert.ToDouble(USD_Field.Text) * usd, true, false);
            }
        }

        void RUB_Field_TextChanged(object sender, TextChangedEventArgs e)// Конвертация из поля для RUB
        {
            Correct(RUB_Field);
            if(rub_activate != false)
            {
                try
                {
                    if (RUB_Field.Text != "")
                        convert(Convert.ToDouble(RUB_Field.Text) * rub, true, true, false);
                }
                catch { }
            }
        }

        void EUR_Field_TextChanged(object sender, TextChangedEventArgs e)// Конвертация из поля для EUR
        {
            Correct(EUR_Field);
            if (eur_activate != false)
            {
                try
                {
                    if (EUR_Field.Text != "")
                        convert(Convert.ToDouble(EUR_Field.Text) * eur, true, true, true, false);
                }
                catch { }
            }
        }

        void UAH_Field_TextChanged(object sender, TextChangedEventArgs e)// Конвертация из поля для UAH
        {
            Correct(UAH_Field);
            if (uah_activate != false)
            {
                try
                {
                    if (UAH_Field.Text != "")
                        convert(Convert.ToDouble(UAH_Field.Text) * uah, true, true, true, true, false);
                }
                catch { }
            }
        }

        static bool byn_activate = false;
        static bool usd_activate = false;
        static bool rub_activate = false;
        static bool eur_activate = false;
        static bool uah_activate = false;
        void BYN_Field_GotFocus(object sender, RoutedEventArgs e)
        {
            byn_activate = true;
        }
        void BYN_Field_LostFocus(object sender, RoutedEventArgs e)
        {
            byn_activate = false;
        }

        void USD_Field_GotFocus(object sender, RoutedEventArgs e)
        {
            usd_activate = true;
        }
        void USD_Field_LostFocus(object sender, RoutedEventArgs e)
        {
            usd_activate = false;
        }

        void RUB_Field_GotFocus(object sender, RoutedEventArgs e)
        {
            rub_activate = true;
        }
        void RUB_Field_LostFocus(object sender, RoutedEventArgs e)
        {
            rub_activate = false;
        }

        void EUR_Field_GotFocus(object sender, RoutedEventArgs e)
        {
            eur_activate = true;
        }
        void EUR_Field_LostFocus(object sender, RoutedEventArgs e)
        {
            eur_activate = false;
        }

        void UAH_Field_GotFocus(object sender, RoutedEventArgs e)
        {
            uah_activate = true;
        }
        void UAH_Field_LostFocus(object sender, RoutedEventArgs e)
        {
            uah_activate = false;
        }
    }
}
