using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Currency_Converter
{
    /// <summary>
    /// Логика взаимодействия для AppSettings.xaml
    /// </summary>
    public partial class AppSettings : Page
    {
        Settings Page_Settings = new Settings();
        public AppSettings()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender,RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();   
           MW.Page_Loader.Navigate(MW.Page_Settings);
        }
    }
}
