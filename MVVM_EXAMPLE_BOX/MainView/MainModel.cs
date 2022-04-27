using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace MVVM_EXAMPLE_BOX.MainView
{
    internal class MainModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public MainModel()
        {
            this.HumanList = new ObservableCollection<Human>();
        }

        private string _Str1 = "";

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

        private string _Str2 = "";

        public string str2
        {
            get => _Str2;
            set
            {
                _Str2 = value;
                OnPropertyChanged("STR1");
            }
        }

        private int _Num1;
        public int num1
        {
            get => _Num1;
            set
            {
                _Num1 = value;
                OnPropertyChanged("NUM1");
            }
        }

        private string _ListName1 = "";

        public string listname1
        {
            get => _ListName1;
            set
            {
                _ListName1 = value;
                OnPropertyChanged("LISTNAME1");
            }
        }

        private readonly ObservableCollection<Human> HumanList;

        public ObservableCollection<Human> humanList
        {
            get => this.HumanList;
        }

        public class Human
        {
            public string _Category { get; set; }
            public string _Name { get; set; }
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

