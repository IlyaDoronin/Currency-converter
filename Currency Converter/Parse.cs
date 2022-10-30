using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Currency_Converter
{
    //Парсинг курсов валют

    public class Parse
    {
        static string city = "";
        static string Link = "";
        static string content = "";
        public Parse() : this("Минск") { }
        public Parse(string town)
        {
            city = town;
            Link = $"https://belarusbank.by/api/kursExchange?city={city}";
            content = GetContent();
        }
        static string GetContent()
        {
            string line = "";
            try
            {
                using (WebClient wc = new WebClient())
                    line = wc.DownloadString(Link);
            }
            catch { }
            return line;
        }

        static string Reg(string expression)
        {
            string result = "";
            Match value = Regex.Match(content, expression);
            result = value.Groups[1].Value;
            if (result == "")
                result = "—";
            return result;
        }
        public static string usd_in // Доллар
        {
            get { return Usd_In(); }
            set { Usd_In(); }
        }
        static string Usd_In()
        {
            return Reg("\"USD_in\":\"([1-9].*?)\"");
        }
        public static string usd_out
        {
            get { return Usd_Out(); }
            set { Usd_Out(); }
        }
        public static string Usd_Out()
        {
            return Reg("\"USD_out\":\"([1-9].*?)\"");
        }

        public static string rub_in // Рос рубль
        {
            get { return Rub_In(); }
            set { Rub_In(); }
        }
        static string Rub_In()
        {
            return Reg("\"RUB_in\":\"([1-9].*?)\"");
        }
        public static string rub_out
        {
            get { return Rub_Out(); }
            set { Rub_Out(); }
        }
        public static string Rub_Out()
        {
            return Reg("\"RUB_out\":\"([1-9].*?)\"");
        }

        public static string eur_in // Евро
        {
            get { return Eur_In(); }
            set { Eur_In(); }
        }
        static string Eur_In()
        {
            return Reg("\"EUR_in\":\"([1-9].*?)\"");
        }
        public static string eur_out
        {
            get { return Eur_Out(); }
            set { Eur_Out(); }
        }
        public static string Eur_Out()
        {
            return Reg("\"EUR_out\":\"([1-9].*?)\"");
        }

        public static string uah_in // Грыуни
        {
            get { return Uah_In(); }
            set { Uah_In(); }
        }
        static string Uah_In()
        {
            return Reg("\"UAH_in\":\"([1-9].*?)\"");
        }
        public static string uah_out
        {
            get { return Uah_Out(); }
            set { Uah_Out(); }
        }
        public static string Uah_Out()
        {
            return Reg("\"UAH_out\":\"([1-9].*?)\"");
        }

        public static string gbp_in // Фунты стерлингов
        {
            get { return Gbp_In(); }
            set { Gbp_In(); }
        }
        static string Gbp_In()
        {
            return Reg("\"GBP_in\":\"([1-9].*?)\"");
        }
        public static string gbp_out
        {
            get { return Gbp_Out(); }
            set { Gbp_Out(); }
        }
        public static string Gbp_Out()
        {
            return Reg("\"GBP_out\":\"([1-9].*?)\"");
        }

        public static string cny_in // Китайский юань
        {
            get { return Cny_In(); }
            set { Cny_In(); }
        }
        static string Cny_In()
        {
            return Reg("\"CNY_in\":\"([1-9].*?)\"");
        }
        public static string cny_out
        {
            get { return Cny_Out(); }
            set { Cny_Out(); }
        }
        public static string Cny_Out()
        {
            return Reg("\"CNY_out\":\"([1-9].*?)\"");
        }

        public static string jpy_in // Японская иена
        {
            get { return Jpy_In(); }
            set { Jpy_In(); }
        }
        static string Jpy_In()
        {
            return Reg("\"JPY_in\":\"([1-9].*?)\"");
        }
        public static string jpy_out
        {
            get { return Jpy_Out(); }
            set { Jpy_Out(); }
        }
        public static string Jpy_Out()
        {
            return Reg("\"JPY_out\":\"([1-9].*?)\"");
        }

        public static string nok_in // Норвежская крона
        {
            get { return Nok_In(); }
            set { Nok_In(); }
        }
        static string Nok_In()
        {
            return Reg("\"NOK_in\":\"([1-9].*?)\"");
        }
        public static string nok_out
        {
            get { return Nok_Out(); }
            set { Nok_Out(); }
        }
        public static string Nok_Out()
        {
            return Reg("\"NOK_out\":\"([1-9].*?)\"");
        }

        public static string cad_in // Канадский доллар
        {
            get { return Cad_In(); }
            set { Cad_In(); }
        }
        static string Cad_In()
        {
            return Reg("\"CAD_in\":\"([1-9].*?)\"");
        }
        public static string cad_out
        {
            get { return Cad_Out(); }
            set { Cad_Out(); }
        }
        public static string Cad_Out()
        {
            return Reg("\"CAD_out\":\"([1-9].*?)\"");
        }

        public static string pln_in // Польский злотый
        {
            get { return Pln_In(); }
            set { Pln_In(); }
        }
        static string Pln_In()
        {
            return Reg("\"PLN_in\":\"([1-9].*?)\"");
        }
        public static string pln_out
        {
            get { return Pln_Out(); }
            set { Pln_Out(); }
        }
        public static string Pln_Out()
        {
            return Reg("\"PLN_out\":\"([1-9].*?)\"");
        }

        public static string sek_in // Шведская крона
        {
            get { return Sek_In(); }
            set { Sek_In(); }
        }
        static string Sek_In()
        {
            return Reg("\"SEK_in\":\"([1-9].*?)\"");
        }
        public static string sek_out
        {
            get { return Sek_Out(); }
            set { Sek_Out(); }
        }
        public static string Sek_Out()
        {
            return Reg("\"CHF_out\":\"([1-9].*?)\"");
        }

        public static string chf_in // Швейцарский франк
        {
            get { return Chf_In(); }
            set { Chf_In(); }
        }
        static string Chf_In()
        {
            return Reg("\"CHF_in\":\"([1-9].*?)\"");
        }
        public static string chf_out
        {
            get { return Chf_Out(); }
            set { Chf_Out(); }
        }
        public static string Chf_Out()
        {
            return Reg("\"CHF_out\":\"([1-9].*?)\"");
        }

        public static string czk_in // Чешская крона
        {
            get { return Czk_In(); }
            set { Czk_In(); }
        }
        static string Czk_In()
        {
            return Reg("\"CZK_in\":\"([1-9].*?)\"");
        }
        public static string czk_out
        {
            get { return Czk_Out(); }
            set { Czk_Out(); }
        }
        public static string Czk_Out()
        {
            return Reg("\"CZK_out\":\"([1-9].*?)\"");
        }
    }
}
