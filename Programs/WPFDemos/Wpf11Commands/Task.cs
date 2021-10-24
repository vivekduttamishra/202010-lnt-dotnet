using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.TaskApi
{


    public class Task : System.ComponentModel.INotifyPropertyChanged
    {



        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; RaisePropertyChanged("Title"); }
        }



        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; RaisePropertyChanged("Description"); }
        }


        private bool done;

        public bool Done
        {
            get { return done; }
            set { done = value; RaisePropertyChanged("Done"); }
        }

        public override string ToString()
        {
            return Title;
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
