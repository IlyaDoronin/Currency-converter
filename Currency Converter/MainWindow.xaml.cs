
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Currency_Converter
{
    public partial class MainWindow : Window
    {
        //Создание экземпляров классов
        public static Courses Page_Cources = new Courses();
        public static Calcutator Page_Calcutator = new Calcutator();
        public static Settings Page_Settings = new Settings();
        public static AppSettings Page_AppSettings = new AppSettings();
        public MainWindow()
        {
            InitializeComponent();
            Load();
        }
        Brush back = (Brush)new BrushConverter().ConvertFromString("#0E1621");
        public Brush color
        {
            get { return back; }
            set { back = value; }
        }
        void Load()
        {
            try
            {
                if(Registry.CurrentUser.CreateSubKey("Software\\Currency converter").GetValue("LastPage").ToString() == "Calcutator")
                    Page_Loader.Navigate(Page_Calcutator);
                else
                    Page_Loader.Navigate(Page_Cources);
            }
            catch
            {
                Page_Loader.Navigate(Page_Cources);
            }
        }
        void TrayOff()
        {
            Show();
            Tray.Visibility = Visibility.Hidden;
        }
        
        void MainForm_Activated(object sender, EventArgs e)
        {
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

        void AppSettings(object sender, RoutedEventArgs e)
        {
            TrayOff();
            Page_Loader.Navigate(Page_AppSettings);
        }

        void MainForm_Closed(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
