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
    /// Логика взаимодействия для TuggleButton.xaml
    /// </summary>
    public partial class TuggleButton : UserControl
    {
        Thickness LeftSide = new Thickness(-150, 0, 0, 0);
        Thickness RightSide = new Thickness(150, 0, 0, 0);
        SolidColorBrush On = new SolidColorBrush(Color.FromRgb(86, 255, 205));
        SolidColorBrush Off = new SolidColorBrush(Color.FromRgb(154, 154, 154));
        SolidColorBrush on = new SolidColorBrush(Color.FromRgb(50, 50, 50));
        SolidColorBrush off = new SolidColorBrush(Color.FromRgb(247, 247, 247));
        private bool Toggled = false;
        public TuggleButton()
        {
            InitializeComponent();
            Back.Fill = Off;
            Toggled = false;
            Dot.Fill = on;
            Dot.Margin = LeftSide;
        }

        public bool Toggled1 { get => Toggled; set => Toggled = value; }

        void Change()
        {
            if (!Toggled)
            {
                Back.Fill = On;
                Toggled = true;
                Dot.Fill = off;
                Dot.Margin = RightSide;
            }
            else
            {
                Back.Fill = Off;
                Toggled = false;
                Dot.Fill = on;
                Dot.Margin = LeftSide;
            }
        }
        private void Dot_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Change();
        }

        private void Back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Change();
        }
    }
}
