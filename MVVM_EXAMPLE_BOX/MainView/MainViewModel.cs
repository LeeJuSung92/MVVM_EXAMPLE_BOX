using System.ComponentModel;

namespace MVVM_EXAMPLE_BOX.MainView
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private MainView.MainModel model;

        public MainViewModel()
        {
            model = new MainView.MainModel();
        }

        public MainView.MainModel Model
        {
            get => model;
            set { model = value; OnPropertyChanged("Model"); }
        }


        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }


    }
}
