using Microsoft.Win32;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace Currency_Converter
{
    public partial class Calcutator : Page
    {
        public Calcutator()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            Date_City dc = new Date_City();
            Date.Content = Date_City.Date;
            City.Content = Date_City.City;
        }

        void Correct(TextBox Input)
        {
            if (Regex.IsMatch(Input.Text, "[^0-9-.]"))
            {
                Input.Text = Input.Text.Remove(Input.Text.Length - 1);
                Input.SelectionStart = Input.Text.Length;
            }
        }
        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            Correct(Input);
        }

        private void Output_TextChanged(object sender, TextChangedEventArgs e)
        {
            Correct(Output);
        }

        private void BYN_Field_TextChanged(object sender, TextChangedEventArgs e)
        {
            Correct(BYN_Field);
        }

        private void USD_Field_TextChanged(object sender, TextChangedEventArgs e)
        {
            Correct(USD_Field);
        }

        private void RUB_Field_TextChanged(object sender, TextChangedEventArgs e)
        {
            Correct(RUB_Field);
        }

        private void EUR_Field_TextChanged(object sender, TextChangedEventArgs e)
        {
            Correct(EUR_Field);
        }

        private void UAH_Field_TextChanged(object sender, TextChangedEventArgs e)
        {
            Correct(UAH_Field);
        }
    }
}
