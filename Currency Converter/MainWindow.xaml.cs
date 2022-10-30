using System;
using System.Diagnostics;
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
        //Создание экземпляров классов
        Courses Page_Cources = new Courses();
        Calcutator Page_Calcutator = new Calcutator();
        public Settings Page_Settings = new Settings();
        public AppSettings Page_AppSettings = new AppSettings();
        public MainWindow()
        {
            InitializeComponent();
            Page_Loader.Navigate(Page_Cources);
        }
        void date()
        {
            ////Task.Factory.StartNew(() =>
            ////{
            //    try
            //    {
            //        //while (true)
            //        //{
            //            Date.Content = (DateTime.Now.Date).ToString("dd.MM.yyyy");
            //            Task.Delay(60000);
            //            GC.Collect();
            //    //    }
            //    } catch { }
            ////});
        }
        void TrayOff()
        {
            Show();
            Tray.Visibility = Visibility.Hidden;
        }
        
        void MainForm_Activated(object sender, EventArgs e)
        {
            date();

        }
        private void DragForm(object sender, MouseButtonEventArgs e)
        {
            try
            { DragMove(); }
            catch { }
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            //Close();
            Process.GetCurrentProcess().Kill();
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

        private void AppSettings(object sender, RoutedEventArgs e)
        {
            TrayOff();
            Page_Loader.Navigate(Page_AppSettings);
        }
    }
}
