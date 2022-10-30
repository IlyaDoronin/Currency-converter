using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Currency_Converter
{
    //Парсинг курсов валют

    public class Parse
    {
        public string City = "ЖЫж";
        public string Name { get; set; }
        //public Parse() : this("Минск") { }
        //public Parse(string City) { this.City = City; }

        public static string link = "https://belarusbank.by/api/kursExchange?city=Минск";//Главная ссылка для парсинга
        public static string USD_IN = "200", USD_OUT;// in - покупка валюты банком out - продажа валюты банком
        public static string BYN_IN, BYN_OUT;
        public static string RUB_IN, RUB_OUT;
        public void Pars(string shedule_in, string shedule_out) //Парсинг информации
        {
            //Task.Run(() =>
            //{
                Match value_in = Regex.Match(link, shedule_in);
                Match value_out = Regex.Match(link, shedule_out);
                //G0_L1.Content = value_in.Groups[1].Value;
                USD_OUT = value_out.Groups[1].Value;
            //});
        }
        //string Row0 = null, string Row1 = null, string Row2 = null, string Row3 = null, string Row4 = null, string Row5 = null, string Row6 = null, string Row7 = null, string Row8 = null, string Row9 = null
        public void Currency(string[] lines = null)
        {
            using (WebClient wc = new WebClient())
                link = wc.DownloadString($"https://belarusbank.by/api/kursExchange?city={City}");
            {
                //Доллар
                Pars("\"USD_in\":\"(.*?)\"", "\"USD_in\":\"(.*?)\"");
                //Бел рубль
                //Pars("\"RUB_in\":\"(.*?)\"", BYN_IN, BYN_OUT);
                //Рос рубль
                //Pars("\"RUB_in\":\"(.*?)\"", RUB_IN, RUB_OUT);
            }
        }
    }
}
