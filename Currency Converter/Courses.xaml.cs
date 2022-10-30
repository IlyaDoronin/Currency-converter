using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Currency_Converter
{
    public partial class Courses : INotifyPropertyChanged
    {
        public Courses()
        {
            DataContext = this;
            InitializeComponent();
        }
        int test = 100;
        int Test
        {
            get { return test;  }
            set
            {
                if(test != value)
                {
                    test = value;
                    OnPropertyChanged();
                }
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
