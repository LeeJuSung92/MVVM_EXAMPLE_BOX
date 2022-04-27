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

        public class AddButtonComaand : ICommand
        {
            MainView.MainModel model;

            public event EventHandler CanExecuteChanged
            {
                // 변화를 감지합니다.
                add
                {
                    CommandManager.RequerySuggested += value;
                }
                remove
                {
                    CommandManager.RequerySuggested += value;
                }
            }

            public AddButtonComaand(MainView.MainModel model)
            {
                this.model=model;
            }

            public bool CanExecute(object parameter)
            {
                // Listname 텍스트 박스가 Null 이 아닐경우에만 할 것
                if (model.listname1.Equals("") != true)
                    return true;
                return false;
            }
            public void Execute(object parameter)
            {
                // 리스트 박스 추가 커맨드를 날리세요
                model.humanList.Add(new MainModel.Human() { _Category = "NAME", _Name = model.listname1});
                
            }

            public void OnCanExecuteChanged()
            {
                CommandManager.InvalidateRequerySuggested();
            }
        }

    }
}
