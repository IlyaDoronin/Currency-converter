using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Currency_Converter
{
    //Парсинг курсов валют

    class Parse
    {
        public string link = "https://belarusbank.by/api/kursExchange?city=Орша";//Главная ссылка для парсинга
        public string USD_IN, USD_OUT;// in - покупка валюты банком out - продажа валюты банком
        public string BYN_IN, BYN_OUT;
        public string RUB_IN, RUB_OUT;
        public string City = "Минск";
        public void Pars(string shedule, string currency) //Парсинг информации
        {
            //Task.Run(() =>
            //{
                Match value = Regex.Match(link, shedule);
                currency = value.Groups[1].Value;
                if (currency == "")
                    currency = "Неизвестно";
                G0_L1.Content = "dfЭЭ";
            //});
        }
        //string Row0 = null, string Row1 = null, string Row2 = null, string Row3 = null, string Row4 = null, string Row5 = null, string Row6 = null, string Row7 = null, string Row8 = null, string Row9 = null
        public void Currency(string City = "Минск", string[] lines = null)
        {
            string result = "";
            foreach (string i in lines)
            {
                result += i;
            }
            try
            {
                using (WebClient wc = new WebClient())
                    link = wc.DownloadString($"https://belarusbank.by/api/kursExchange?city={City}");
                {
                    //Доллар
                    Pars("\"USD_in\":\"(.*?)\"", USD_IN);
                    //Бел рубль
                    Pars("\"RUB_in\":\"(.*?)\"", BYN_IN);
                    //Рос рубль
                    Pars("\"RUB_in\":\"(.*?)\"", RUB_IN);
                }
            }
            catch { }
        }
    }
}
