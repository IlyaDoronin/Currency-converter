using Microsoft.Win32;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Currency_Converter
{
    public partial class Calcutator : Page
    {
        public Calcutator()
        {
            InitializeComponent();          
            Date.Content = (DateTime.Now.Date).ToString("dd.MM.yyyy");
        }
        
        private void Page_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            //Update();
        }
        async public void Update(string town = "Минск")
        {
            Parallel.Invoke(() =>
            {
                while (true)
                {
                    Parse p = new Parse(town);
                    DataContext = p;
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
