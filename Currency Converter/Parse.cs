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
        static string City = "";
        static string Link = "";
        static string content = "";
        public Parse() : this("Минск") { }
        public Parse(string town)
        {
            City = town;
            Link = $"https://belarusbank.by/api/kursExchange?city={City}";
            content = GetContent();
            Usd_In();
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
            return result;
        }
            public static string usd_in;
            public static string usd { get { return usd_in; } }
        static string Usd_In()
        {
            usd_in = Reg("\"USD_in\":\"(.*?)\"");
            return usd_in;
        }
        public static string Usd_Out()
        {
            return Reg("\"USD_out\":\"(.*?)\"");
        }
    }
}
