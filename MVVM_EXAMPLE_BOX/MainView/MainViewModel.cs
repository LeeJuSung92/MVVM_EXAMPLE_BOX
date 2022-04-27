using System.ComponentModel;
using System.Collections.ObjectModel;

namespace MVVM_EXAMPLE_BOX.MainView
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private MainView.MainModel model;
        public MainView.Command.UPButtonCommand _upButtonCMD { get; set; }  
        public MainView.Command.AddButtonComaand _addButtonCMD { get; set; }    
        

        public MainViewModel()
        {
            model = new MainView.MainModel();
            _upButtonCMD = new MainView.Command.UPButtonCommand(model);
            _addButtonCMD = new MainView.Command.AddButtonComaand(model);


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
