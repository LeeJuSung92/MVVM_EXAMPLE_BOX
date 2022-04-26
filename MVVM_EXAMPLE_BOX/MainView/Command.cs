using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_EXAMPLE_BOX.MainView
{
    internal class Command
    {

        public class UPButtonCommand : ICommand
        {
            MainView.MainModel model;

            public UPButtonCommand(MainView.MainModel model)
            {
                this.model = model;
            }

            public event EventHandler? CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                return true;
            }
            public void Execute(object parameter)
            {
                model.num1++;
            }
        }

    }
}
