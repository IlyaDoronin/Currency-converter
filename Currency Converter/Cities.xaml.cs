using System;
using System.Windows;

namespace Currency_Converter
{
    /// <summary>
    /// Логика взаимодействия для Cities.xaml
    /// </summary>
    public partial class Cities : Window
    {
        void сlose()
        {
            Close();
        }

        public Cities()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //сlose();
            Hide();
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            GC.Collect();
        }
    }
}
