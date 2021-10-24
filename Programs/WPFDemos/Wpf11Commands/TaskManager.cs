using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf11Commands
{


    public class TaskManager : System.ComponentModel.INotifyPropertyChanged
    {


        private Task currentTask;

        public Task CurrentTask
        {
            get { return currentTask; }
            set { currentTask = value; IsModified = true;
                    RaisePropertyChanged("CurrentTask"); }
        }


        public List<Task> Tasks { get; set; } = new List<Task>();




        private bool isNew;

        public bool IsNew
        {
            get { return isNew; }
            set { isNew = value; RaisePropertyChanged("IsNew"); }
        }




        private bool isModified;

        public bool IsModified
        {
            get { return isModified; }
            set { isModified = value; RaisePropertyChanged("IsModified"); }
        }

        public TaskManager()
        {
            CurrentTask = new Task();
            Tasks = new List<Task>();
            IsNew = true;
            IsModified = false;
        }


        public void AddTask()
        {
            Tasks.Add(CurrentTask);
            IsNew = false;
            IsModified = true;
        }

        public void CreateNewTask()
        {
            CurrentTask = new Task();
            IsNew = true;
            IsModified = true;
        }

        public void RemoveTask()
        {
            Tasks.Remove(CurrentTask);
            IsModified = true;
            CreateNewTask();
        }

        public void Save()
        {
            IsModified = false;
        }



        [NonSerialized]
        System.ComponentModel.PropertyChangedEventHandler _propertyChanged;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                _propertyChanged += value;
            }
            remove
            {
                _propertyChanged -= value;
            }
        }

        protected void RaisePropertyChanged(params string[] propertyNames)
        {
            if (_propertyChanged == null)
                return;
            if (propertyNames.Length == 0 || (propertyNames.Length == 1 && propertyNames[0] == "*"))
                _propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(null));
            else
            {
                foreach (var name in propertyNames)
                    _propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(name));
            }
        }
    }

}
