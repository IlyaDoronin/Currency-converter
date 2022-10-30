using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        public byte Currency_Count;
        public Settings()
        {
            InitializeComponent();
        }

        void Button_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow MW = new MainWindow();
            //MainWindow.Page_Loader.Navigate(Page_AppSettings);
        }

        void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TUSD.IsChecked = true;
            TRUB.IsChecked = true;
            TEUR.IsChecked = true;
            TUAH.IsChecked = true;
            TGBP.IsChecked = true;
            TCNY.IsChecked = true;
            TJPY.IsChecked = true;
            TNOK.IsChecked = true;
            TCAD.IsChecked = true;
            TPLN.IsChecked = true;
            TSEK.IsChecked = false;
            TCHF.IsChecked = false;
            TCZK.IsChecked = false;
        }

        void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TUSD.IsChecked = false;
            TRUB.IsChecked = false;
            TEUR.IsChecked = false;
            TUAH.IsChecked = false;
            TGBP.IsChecked = false;
            TCNY.IsChecked = false;
            TJPY.IsChecked = false;
            TNOK.IsChecked = false;
            TCAD.IsChecked = false;
            TPLN.IsChecked = false;
            TSEK.IsChecked = false;
            TCHF.IsChecked = false;
            TCZK.IsChecked = false;
     
            //foreach (ToggleButton toggle in Settings.)
            //{
            //    if (toggle.IsChecked == true)
            //        toggle.IsChecked = false;
            //}
        }
    }
}
