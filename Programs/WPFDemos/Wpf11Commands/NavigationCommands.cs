using ConceptArchitect.TaskApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ConceptArchitect.Commands
{
    public class NavigateNextCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        TaskManager manager;

        public NavigateNextCommand(TaskManager manager)
        {
            this.manager = manager;
        }

        public bool CanExecute(object parameter)
        {
            return manager.Tasks.Count > 0 && manager.CurrentTaskIndex < manager.Tasks.Count - 1;
        }

        public void Execute(object parameter)
        {
            var next = manager.CurrentTaskIndex + 1;
            manager.CurrentTask = manager.Tasks[next];

        }
    }


    public class NavigatePreviousCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        TaskManager manager;

        public NavigatePreviousCommand(TaskManager manager)
        {
            this.manager = manager;
        }

        public bool CanExecute(object parameter)
        {
            return manager.Tasks.Count > 0 && manager.CurrentTaskIndex > 0;
        }

        public void Execute(object parameter)
        {
            var next = manager.CurrentTaskIndex - 1;
            manager.CurrentTask = manager.Tasks[next];

        }
    }


    public class NavigateFirstCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        TaskManager manager;

        public NavigateFirstCommand(TaskManager manager)
        {
            this.manager = manager;
        }

        public bool CanExecute(object parameter)
        {
            return manager.Tasks.Count > 0 && manager.CurrentTaskIndex != 0;
        }

        public void Execute(object parameter)
        {
            
            manager.CurrentTask = manager.Tasks[0];

        }
    }


    public class NavigateLastCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        TaskManager manager;

        public NavigateLastCommand(TaskManager manager)
        {
            this.manager = manager;
        }

        public bool CanExecute(object parameter)
        {
            return manager.Tasks.Count > 0 && manager.CurrentTaskIndex != manager.Tasks.Count-1;
        }

        public void Execute(object parameter)
        {
            
            manager.CurrentTask = manager.Tasks[manager.Tasks.Count-1];

        }
    }




}
