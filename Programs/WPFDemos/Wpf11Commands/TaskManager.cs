using ConceptArchitect.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.TaskApi
{


    public class TaskManager : System.ComponentModel.INotifyPropertyChanged
    {

        public NavigateNextCommand  NavigateNext { get; set; }
        public NavigatePreviousCommand NavigatePrevious { get; set; }

        public NavigateFirstCommand NavigateFirst { get; set; }

        public NavigateLastCommand NavigateLast { get; set; }


        public TaskManager()
        {
            CurrentTask = null;

            LoadTasks(); //dummy load
            IsNew = true;
            IsModified = false;

            NavigateFirst = new NavigateFirstCommand(this);
            NavigateLast = new NavigateLastCommand(this);
            NavigatePrevious = new NavigatePreviousCommand(this);
            NavigateNext = new NavigateNextCommand(this);

        }




        private int currentTaskIndex;

        public int CurrentTaskIndex
        {
            get { return currentTaskIndex; }
            set { 
            
                currentTaskIndex = value; 
                RaisePropertyChanged("CurrentTaskIndex"); 
            
            }
        }





        private Task currentTask;

        public Task CurrentTask
        {
            get { return currentTask; }
            set 
            { 

                currentTask = value;
                CurrentTaskIndex = Tasks.IndexOf(CurrentTask);
                IsNew = false;
                IsModified = true;
                Status = "Selected";
                RaisePropertyChanged("CurrentTask"); 
            }
        }


        //public List<Task> Tasks { get; set; } = new List<Task>();

        public ObservableCollection<Task> Tasks { get; set; } = new ObservableCollection<Task>();




        private bool isNew;

        public bool IsNew
        {
            get { return isNew; }
            set { isNew = value; RaisePropertyChanged("IsNew"); }
        }



        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; RaisePropertyChanged("Status"); }
        }





        private bool isModified;

        public bool IsModified
        {
            get { return isModified; }
            set { isModified = value; RaisePropertyChanged("IsModified"); }
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
            Status = "New Task";
            IsNew = true;
            IsModified = true;
        }

        public void RemoveTask()
        {
            Tasks.Remove(CurrentTask);
            RaisePropertyChanged("Tasks");
            IsModified = true;
            CurrentTask = null;
            //CreateNewTask();
        }

        public void Save()
        {
            IsModified = false;
            Status = "Saved";
        }

        //load dummy tasks
        public void LoadTasks()
        {
            Tasks.Add(new Task() { Title = "Learn WPF Commands", Description = "We Need to understand WPF Commands in Details" });
            Tasks.Add(new Task() { Title = "Learn Binding", Description = "Different types of Binding help us write less code",Done=true });
            Tasks.Add(new Task() { Title = "WCF Service", Description = "Implement Service using WCF", Done = true });
            Tasks.Add(new Task() { Title = "Styles", Description = "Help us create decent app with consistent style" });
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
