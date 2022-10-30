using Microsoft.Win32;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Currency_Converter
{
    public partial class Calcutator : Page
    {
        static double usd = 1;
        static double rub = 1;
        static double eur = 1;
        static double uah = 1;
        static double gbp = 1;
        static double cny = 1;
        static double jpy = 1;
        static double nok = 1;
        static double cad = 1;
        static double pln = 1;
        static double sek = 1;
        static double chf = 1;
        static double czk = 1;
        public Calcutator()
        {
            Update();
            InitializeComponent();
            Date.Content = (DateTime.Now.Date).ToString("dd.MM.yyyy");
        }

        void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BYN_Field.Focus();
            Registry.CurrentUser.CreateSubKey("Software\\Currency converter").SetValue("LastPage", "Calcutator");
        }
        Parse pr = Courses.p;
        static string line = "";
        async void Update()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    try
                    {
                        line = GetContent();
                        usd = Reg("\"Доллар США\",\"Cur_OfficialRate\":(.*?)}");
                        to = usd;
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
                    } catch { }
                    Thread.Sleep(10000);
                }
            });
        }
        void Correct(TextBox Input)
        {
            if (Regex.IsMatch(Input.Text, "[^0-9-.]"))
            {
                Input.Text = Input.Text.Remove(Input.Text.Length - 1);
                Input.SelectionStart = Input.Text.Length;
            }
            if (Input.Text == "")
            {
                BYN_Field.Text = "";
                USD_Field.Text = "";
                RUB_Field.Text = "";
                EUR_Field.Text = "";
                UAH_Field.Text = "";
            }
        }
        static string GetContent()
        {
            string l = "";
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = Encoding.UTF8;
                    l = wc.DownloadString("https://www.nbrb.by/api/exrates/rates?periodicity=0");
                    Thread.Sleep(1000);
                }
            }
            catch { }
            return l;
        }
        static double Reg(string expression)
        {
            string result = "";
            Match value = Regex.Match(line, expression);
            result = value.Groups[1].Value;
            if (result == null)
                result = "0";
            return Convert.ToDouble(result.Replace(".", ","));
        }
        double Convert_From()
        {
            double currency = 1;
            switch (Cur_Input.Text)
            {
                case "BYN":
                    currency = 1;
                    break;
                case "USD":
                    currency = usd;
                    break;
                case "RUB":
                    currency = rub;
                    break;
                case "EUR":
                    currency = eur;
                    break;
                case "UAH":
                    currency = uah;
                    break;
                case "GBP":
                    currency = gbp;
                    break;
                case "CNY":
                    currency = cny;
                    break;
                case "JPY":
                    currency = jpy;
                    break;
                case "NOK":
                    currency = nok;
                    break;
                case "CAD":
                    currency = cad;
                    break;
                case "PLN":
                    currency = pln;
                    break;
                case "SEK":
                    currency = sek;
                    break;
                case "CHF":
                    currency = chf;
                    break;
                case "CZK":
                    currency = czk;
                    break;
            }
            return currency;
        }
        double Convert_To()
        {
            double currency = 1;
            switch (Cur_Output.Text)
            {
                case "BYN":
                    currency = 1;
                    break;
                case "USD":
                    currency = usd;
                    break;
                case "RUB":
                    currency = rub;
                    break;
                case "EUR":
                    currency = eur;
                    break;
                case "UAH":
                    currency = uah;
                    break;
                case "GBP":
                    currency = gbp;
                    break;
                case "CNY":
                    currency = cny;
                    break;
                case "JPY":
                    currency = jpy;
                    break;
                case "NOK":
                    currency = nok;
                    break;
                case "CAD":
                    currency = cad;
                    break;
                case "PLN":
                    currency = pln;
                    break;
                case "SEK":
                    currency = sek;
                    break;
                case "CHF":
                    currency = chf;
                    break;
                case "CZK":
                    currency = czk;
                    break;
            }
            return currency;
        }
        static double from = 1;
        static double to = 1;
        void Input_TextChanged(object sender, TextChangedEventArgs e) // Поле конвертации из
        {
            Correct(Input);
            if (input_activate != false)
            {
                try
                {
                    if (Input.Text != "")
                    {
                        double content = Convert.ToDouble(Input.Text.Replace(".", ",")) * from / to;
                        Output.Text = string.Format("{0:0.####}", content).Replace(",", ".");
                    }
                    else
                        Output.Text = "";
                }
                catch { }
            }
        }

        void Output_TextChanged(object sender, TextChangedEventArgs e) // Поле конвертации в
        {
            Correct(Output);
            if (output_activate != false)
            {
                try
                {
                    if (Output.Text != "")
                    {
                        double content = Convert.ToDouble(Output.Text.Replace(".", ",")) * to / from;
                        Input.Text = string.Format("{0:0.####}", content).Replace(",", ".");
                    }
                    else
                        Input.Text = "";
                }
                catch { }
            }
        }
        void convert(double value = 0, bool BYN = true, bool USD = true, bool RUB = true, bool EUR = true, bool UAH = true)
        {
            try
            {
                double content = Convert.ToDouble(value);
                if (BYN == true)
                    BYN_Field.Text = string.Format("{0:0.####}", value).Replace(",", ".");
                if (USD == true)
                    USD_Field.Text = string.Format("{0:0.####}", content / usd).Replace(",", ".");
                if (RUB == true)
                    RUB_Field.Text = string.Format("{0:0.####}", content / rub).Replace(",", ".");
                if (EUR == true)
                    EUR_Field.Text = string.Format("{0:0.####}", content / eur).Replace(",", ".");
                if (UAH == true)
                    UAH_Field.Text = string.Format("{0:0.####}", content / uah).Replace(",", ".");
            }
            catch { }
        }
        void BYN_Field_TextChanged(object sender, TextChangedEventArgs e)// Конвертация из поля для BYN
        {
            Correct(BYN_Field);
            if (byn_activate != false)
            {
                try
                {
                    if (BYN_Field.Text != "")
                        convert(Convert.ToDouble(BYN_Field.Text.Replace(".", ",")), false);
                }
                catch { }
            }
        }

        void USD_Field_TextChanged(object sender, TextChangedEventArgs e) // Конвертация из поля для USD
        {
            if (usd_activate != false)
            {
                try
                {
                    Correct(USD_Field);
                    if (USD_Field.Text != "")
                        convert(Convert.ToDouble(USD_Field.Text.Replace(".", ",")) * usd, true, false);
                }
                catch { }
            }
        }

        void RUB_Field_TextChanged(object sender, TextChangedEventArgs e)// Конвертация из поля для RUB
        {
            Correct(RUB_Field);
            if (rub_activate != false)
            {
                try
                {
                    if (RUB_Field.Text != "")
                        convert(Convert.ToDouble(RUB_Field.Text.Replace(".", ",")) * rub, true, true, false);
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
                        convert(Convert.ToDouble(EUR_Field.Text.Replace(".", ",")) * eur, true, true, true, false);
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
                        convert(Convert.ToDouble(UAH_Field.Text.Replace(".", ",")) * uah, true, true, true, true, false);
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
        void Input_GotFocus(object sender, RoutedEventArgs e)
        {
            input_activate = true;
        }
        void Input_LostFocus(object sender, RoutedEventArgs e)
        {
            input_activate = false;
        }

        void Output_GotFocus(object sender, RoutedEventArgs e)
        {
            output_activate = true;
        }
        void Output_LostFocus(object sender, RoutedEventArgs e)
        {
            output_activate = false;
        }

        void Cur_Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            from = Convert_From();
            if (Output.Text != "")
            {
                double content = Convert.ToDouble(Output.Text.Replace(".", ",")) * to / from;
                Input.Text = string.Format("{0:0.####}", content).Replace(",", ".");
            }
            else
                Input.Text = "";
        }
        void Cur_Output_TextChanged(object sender, TextChangedEventArgs e)
        {
            to = Convert_To();
            if (Input.Text != "")
            {
                double content = Convert.ToDouble(Input.Text.Replace(".", ",")) * from / to;
                Output.Text = string.Format("{0:0.####}", content).Replace(",", ".");
            }
            else
                Output.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("usd  " + usd.ToString() + "\n" +
                            "rub  " + rub.ToString() + "\n" +
                            "eur  " + eur.ToString() + "\n" +
                            "uah  " + uah.ToString() + "\n" +
                            "gbp  " + gbp.ToString() + "\n" +
                            "cny  " + cny.ToString() + "\n" +
                            "jpy  " + jpy.ToString() + "\n" +
                            "nok  " + nok.ToString() + "\n" +
                            "cad  " + cad.ToString() + "\n" +
                            "pln  " + pln.ToString() + "\n" +
                            "sek  " + sek.ToString() + "\n" +
                            "chf  " + chf.ToString() + "\n" +
                            "czk  " + czk.ToString() + "\n"+
                            "from  " + from.ToString() + "\n"+
                            "to  " + to.ToString() + "\n");
        }

        private void Buton_Click(object sender, RoutedEventArgs e)
        {
            string l = "";
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = Encoding.UTF8;
                    l = wc.DownloadString("https://www.nbrb.by/api/exrates/rates?periodicity=0");
                }
            MessageBox.Show(l);
            }
            catch
            {
                MessageBox.Show("ЕЕЕ исключение словилось");
            }
        }
    }
}