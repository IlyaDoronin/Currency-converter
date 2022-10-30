using System;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows;

namespace Currency_Converter
{
    class Date_City
    {
        public static string City;
        public static string Date;
        public Date_City()
        {
            city();
            date();
        }
        async void city()
        {
            await Task.Run(() =>
            {
                if (Registry.CurrentUser.CreateSubKey(@"Software\Currency converter").GetValue("City")?.ToString() != null)
                    City = Registry.CurrentUser.CreateSubKey(@"Software\Currency converter").GetValue("City")?.ToString();
                else
                    City = "Минск";
            });
        }

        void date()
        {
             Date = (DateTime.Now.Date).ToString("dd.MM.yyyy");
        }

    }
}
