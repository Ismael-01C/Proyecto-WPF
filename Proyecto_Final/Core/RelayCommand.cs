using System;
using System.Windows.Input;

namespace Proyecto_Final.Core
{
    //son implementaciones de ICommand que pueden exponer un método o delegado a la vista.
    class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;   
         
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null  || canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
