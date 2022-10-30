using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace Currency_Converter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        async void time()
        {
            while (true)
            {
                Time.Content = (DateTime.Now).ToString().Remove(0,11);
                await Task.Delay(1000);
                GC.Collect();
            }
        }
        async void date()
        {
            try
            {
                while (true)
                {
                    Date.Content = (DateTime.Now).ToString().Remove(11, 8);
                    await Task.Delay(60000);
                    GC.Collect();
                }
            } catch { }
        }
        
        void TrayOff()
        {
            Show();
            Tray.Visibility = Visibility.Hidden;
        }


        private void MainForm_Activated(object sender, EventArgs e)
        {
            time();
            date();
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
        }
                
        void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
        }

        void Course_Click(object sender, RoutedEventArgs e)
        {
            TrayOff();
            Table.Visibility = Visibility.Visible;
        }
        void Calcutater_Click(object sender, RoutedEventArgs e)
        {
            TrayOff();
            Table.Visibility = Visibility.Hidden;
        }
    }
}