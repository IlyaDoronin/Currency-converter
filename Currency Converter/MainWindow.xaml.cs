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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DragForm(object sender, MouseButtonEventArgs e)
        {

            try
            {
                DragMove();
            }
            catch { }
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void FullScreen(object sender, RoutedEventArgs e)
        {
            if(MainForm.WindowState == WindowState.Maximized)
            {
                MainForm.Height = 750;
                MainForm.Width = 550;
            }
            else
            {
                MainForm.WindowState = WindowState.Maximized;
            }
        }
        private void Minimized(object sender, RoutedEventArgs e)
        {
            MainForm.WindowState = WindowState.Minimized;
        }
        private void TrayMinimized(object sender, RoutedEventArgs e)
        {
        }
        private void Settings(object sender, RoutedEventArgs e)
        {
        }
        
        private void CloseForm_MouseEnter(object sender, MouseEventArgs e)
        {
        }
    }
}
