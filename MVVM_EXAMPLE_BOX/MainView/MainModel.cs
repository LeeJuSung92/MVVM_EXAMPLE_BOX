using System.ComponentModel;

namespace MVVM_EXAMPLE_BOX.MainView
{
    internal class MainModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string _Str1;

        public string str1
        {
            get => _Str1;
            set
            {
                _Str1 = value;
                _Str2 = _Str1;
                OnPropertyChanged("STR2");
            }

        }

        private string _Str2;

        public string str2
        {
            get => _Str2;
            set
            {
                _Str2 = value;
                OnPropertyChanged("STR1");
            }
        }





        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}

