using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wpf_DopPLNSK_Resume
{
    class DlgCmdResume : ICommand
    {
        Action<object> m_execute;
        Predicate<object> m_canExecute;
        public DlgCmdResume(Action<object> execute, Predicate<object> canExecute)
        {
            m_execute = execute ?? throw new ArgumentNullException("execute");
            m_canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return m_canExecute == null ? true : m_canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            m_execute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

    }
}
