using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Currency_Converter
{
    public partial class MainWindow : Window
    {
        Courses Page_Cources = new Courses();
        Settings Page_Settings = new Settings();
        Calcutator Page_Calcutator = new Calcutator();
        public MainWindow()
        {
            InitializeComponent();
            Page_Loader.Navigate(Page_Cources);
        }
        void date()
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    while (true)
                    {
                        Date.Content = (DateTime.Now.Date).ToString("dd.MM.yyyy");
                        Task.Delay(60000);
                        GC.Collect();
                    }
                } catch { }
            });
        }
        void TrayOff()
        {
            Show();
            Tray.Visibility = Visibility.Hidden;
        }
        
        void MainForm_Activated(object sender, EventArgs e)
        {
            City.Content = "Минск"; //Реестр
            date();
            Parse qq = new Parse();

        }
        private void DragForm(object sender, MouseButtonEventArgs e)
        {
            try
            { DragMove(); }
            catch { }
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void FullScreen(object sender, RoutedEventArgs e)
        {
            if (MainForm.WindowState == WindowState.Maximized)
            {
                MainForm.WindowState = WindowState.Normal;
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

        // Сворачивание в трей Hardcodet.Wpf.TaskbarNotification
        void TrayMinimized(object sender, RoutedEventArgs e)
        {
            Hide();
            Tray.Visibility = Visibility.Visible;
        }
        void TaskbarIcon_TrayLeftMouseDown(object sender, RoutedEventArgs e)
        {
            TrayOff();
        }
        void Settings(object sender, RoutedEventArgs e)
        {
            TrayOff();
            Page_Loader.Navigate(Page_Settings);
        }
                
        void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Course.Content += e.Key.ToString();
        }
        void Course_Click(object sender, RoutedEventArgs e)
        {
            TrayOff();
            Page_Loader.Navigate(Page_Cources);
        }
        void Calcutator_Click(object sender, RoutedEventArgs e)
        {
            TrayOff();
            Page_Loader.Navigate(Page_Calcutator);
        }
    }
}
