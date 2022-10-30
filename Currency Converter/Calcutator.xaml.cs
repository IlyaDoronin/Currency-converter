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
        static double gbp = 0;
        static double cny = 0;
        static double jpy = 0;
        static double nok = 0;
        static double cad = 0;
        static double pln = 0;
        static double sek = 0;
        static double chf = 0;
        static double czk = 0;
        public Calcutator()
        {
            InitializeComponent();          
            Date.Content = (DateTime.Now.Date).ToString("dd.MM.yyyy");
            Content = GetContent();
            Update();
        }

        void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Update();
        }

        Parse pr = Courses.p;
        void Update(string town = "Минск")
        {
            Task.Factory.StartNew(() =>
            {                 
                usd = Reg("\"Доллар США\",\"Cur_OfficialRate\":(.*?)}");
                rub = Reg("\"Российских рублей\",\"Cur_OfficialRate\":(.*?)}") / 100;
                eur = Reg("\"Евро\",\"Cur_OfficialRate\":(.*?)}");
                uah = Reg("\"Гривен\",\"Cur_OfficialRate\":(.*?)}") / 100;
                gbp = Reg("\"Фунт стерлингов\",\"Cur_OfficialRate\":(.*?)}");
                cny = Reg("\"Китайских юаней\",\"Cur_OfficialRate\":(.*?)}") / 10;
                jpy = Reg("\"Йен\",\"Cur_OfficialRate\":(.*?)}") / 100;
                nok = Reg("\"Норвежских крон\",\"Cur_OfficialRate\":(.*?)}") / 10;
                cad = Reg("\"Канадский доллар\",\"Cur_OfficialRate\":(.*?)}");
                pln = Reg("\"Злотых\",\"Cur_OfficialRate\":(.*?)}") / 10;
                sek = Reg("\"Шведских крон\",\"Cur_OfficialRate\":(.*?)}") / 10;
                chf = Reg("\"Швейцарский франк\",\"Cur_OfficialRate\":(.*?)}");
                czk = Reg("\"Чешских крон\",\"Cur_OfficialRate\":(.*?)}") / 100;
            });
        }
        void Correct(TextBox Input)
        {
            if (Regex.IsMatch(Input.Text, "[^0-9-,]"))
            {
                Input.Text = Input.Text.Remove(Input.Text.Length - 1);
                Input.SelectionStart = Input.Text.Length;
            }
            if(Input.Text == "")
            {
                BYN_Field.Text = "";
                USD_Field.Text = "";
                RUB_Field.Text = "";
                EUR_Field.Text = "";
                UAH_Field.Text = "";
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
        double Convert_From()
        {
            double currency = 1;
            switch (Cur_Input.Text)
            {
                case "BYN": currency = 1;
                    break;
                case "USD": currency = usd;
                    break;
                case "RUB": currency = rub;
                    break;
                case "EUR": currency = eur;
                    break;
                case "UAH": currency = uah;
                    break;
                case "GBP": currency = gbp;
                    break;
                case "CNY": currency = cny;
                    break;
                case "JPY": currency = jpy;
                    break;
                case "NOK": currency = nok;
                    break;
                case "CAD": currency = cad;
                    break;
                case "PLN": currency = pln;
                    break;
                case "SEK": currency = sek;
                    break;
                case "CHF": currency = chf;
                    break;
                case "CZK": currency = czk;
                    break;
            }
            return currency;
        }
        double Convert_To()
        {
            double currency = 1;
            switch (Cur_Output.Text)
            {
                case "BYN": currency = 1;
                    break;
                case "USD": currency = usd;
                    break;
                case "RUB": currency = rub;
                    break;
                case "EUR": currency = eur;
                    break;
                case "UAH": currency = uah;
                    break;
                case "GBP": currency = gbp;
                    break;
                case "CNY": currency = cny;
                    break;
                case "JPY": currency = jpy;
                    break;
                case "NOK": currency = nok;
                    break;
                case "CAD": currency = cad;
                    break;
                case "PLN": currency = pln;
                    break;
                case "SEK": currency = sek;
                    break;
                case "CHF": currency = chf;
                    break;
                case "CZK": currency = czk;
                    break;
            }
            return currency;
        }
        static double from = 1;
        static double to = 1;
        static double BYN_from = 1;
        static double BYN_to = 1;
        void Input_TextChanged(object sender, TextChangedEventArgs e) // Поле конвертации из
        {
            Correct(Input);
            if (input_activate != false)
            {
                if (Input.Text != "")
                {
                    double content = Convert.ToDouble(Input.Text);
                    Output.Text = (content * to).ToString("F" + 4);
                }
            }
        }

        void Output_TextChanged(object sender, TextChangedEventArgs e) // Поле конвертации в
        {
            Correct(Output);
            if (output_activate != false)
            {
                if (Output.Text != "")
                {
                    double content = Convert.ToDouble(Output.Text);
                    content = 0;
                }
            }
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

        static bool input_activate = false;
        static bool output_activate = false;
        private void Input_GotFocus(object sender, RoutedEventArgs e)
        {
            input_activate = true;
        }
        private void Input_LostFocus(object sender, RoutedEventArgs e)
        {
            input_activate = false;
        }

        private void Output_GotFocus(object sender, RoutedEventArgs e)
        {
            output_activate = true;
        }
        private void Output_LostFocus(object sender, RoutedEventArgs e)
        {
            output_activate = false;
        }
        
        private void Cur_Input_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            from = Convert_From();
        }
        private void Cur_Output_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            to = Convert_To();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(from + "\n" + to);
            //to = usd;
        }
    }
}
