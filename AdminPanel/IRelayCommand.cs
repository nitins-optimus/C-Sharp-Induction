using System;
using System.Windows.Input;

namespace AdminPanel
{
    public interface IRelayCommand:ICommand
    {
        void RaiseCanExecuteChanged();
    }
}