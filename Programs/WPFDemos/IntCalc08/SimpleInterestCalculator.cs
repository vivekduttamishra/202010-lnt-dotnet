using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConceptArchitect.Finance
{
    public class SimpleInterestCalculator : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public bool IsValid { 
            get 
            {
                return Principal >= 1000 && Principal % 1000 == 0
                        && Rate > 3
                        && Period >= 6 && Period % 6 == 0;
            
            } 
        }

        protected void NotifyPropertyChanged(params string[] properties)
        {
            if (PropertyChanged == null)
                return;

            if (properties.Length == 0)
                PropertyChanged(this, new PropertyChangedEventArgs(null)); //say all property changed
            else
            {
                foreach (var property in properties)
                    PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private double principal;

        public double Principal
        {
            get { return principal; }
            set { principal = value; NotifyPropertyChanged("Principal"); }
        }

        private double rate;

        public double Rate
        {
            get { return rate; }
            set { rate = value; NotifyPropertyChanged("Rate"); }
        }


        private int period;

        public int Period
        {
            get { return period; }
            set { period = value; NotifyPropertyChanged("Period"); }
        }


        private double intrest;

        public double Interest
        {
            get { return intrest; }
            set { intrest = value; NotifyPropertyChanged("Interest"); }
        }

        private double amount;

        public double Amount
        {
            get { return amount; }
            set { amount = value; NotifyPropertyChanged("Amount"); }
        }


        private bool isAutoCompute;

        public bool IsAutoCompute
        {
            get { return isAutoCompute; }
            set { isAutoCompute = value; NotifyPropertyChanged("IsAutoCompute"); }
        }



      



        public void Compute()
        {
            Interest = Principal * Rate * Period / 1200;
            Amount = Principal + Interest;
        }


        public SimpleInterestCalculator()
        {
            this.PropertyChanged += (s, e) =>
            {
                if (IsAutoCompute && (e.PropertyName=="Principal" || e.PropertyName=="Rate" || e.PropertyName=="Period"))
                    Compute();
            };
        }
    }
}
