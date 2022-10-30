using Microsoft.Win32;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Currency_Converter
{
    public partial class Courses
    {
        public Courses()
        {
            InitializeComponent();
            Date_City dc = new Date_City();
            Date.Content = Date_City.Date;
            City.Content = Date_City.City;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Parse p = new Parse("Орша");
            G0_L1.Content = Parse.usd_in;
            G0_L2.Content = Parse.Usd_Out();
        }
    }
}
