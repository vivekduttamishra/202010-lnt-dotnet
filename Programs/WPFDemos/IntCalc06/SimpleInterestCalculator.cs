using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConceptArchitect.Finance
{
    public class SimpleInterestCalculator : DependencyObject
    {


        public double Principal
        {
            get { return (double)GetValue(PrincipalProperty); }
            set { SetValue(PrincipalProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Principal.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PrincipalProperty =
            DependencyProperty.Register("Principal", typeof(double), typeof(SimpleInterestCalculator), new PropertyMetadata(0.0));




        public double Rate
        {
            get { return (double)GetValue(RateProperty); }
            set { SetValue(RateProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Rate.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RateProperty =
            DependencyProperty.Register("Rate", typeof(double), typeof(SimpleInterestCalculator), new PropertyMetadata(0.0));





        public int Period
        {
            get { return (int)GetValue(PeriodProperty); }
            set { SetValue(PeriodProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Period.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PeriodProperty =
            DependencyProperty.Register("Period", typeof(int), typeof(SimpleInterestCalculator), new PropertyMetadata(0));





        public double Amount
        {
            get { return (double)GetValue(AmountProperty); }
            set { SetValue(AmountProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Amount.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AmountProperty =
            DependencyProperty.Register("Amount", typeof(double), typeof(SimpleInterestCalculator), new PropertyMetadata(0.0));





        public double Interest
        {
            get { return (double)GetValue(InterestProperty); }
            set { SetValue(InterestProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Interest.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InterestProperty =
            DependencyProperty.Register("Interest", typeof(double), typeof(SimpleInterestCalculator), new PropertyMetadata(0.0));




        public bool IsAutoCompute
        {
            get { return (bool)GetValue(IsAutoComputeProperty); }
            set { SetValue(IsAutoComputeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsAutoCompute.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsAutoComputeProperty =
            DependencyProperty.Register("IsAutoCompute", typeof(bool), typeof(SimpleInterestCalculator), new PropertyMetadata(false));





        public void Compute()
        {
            Interest = Principal * Rate * Period / 1200;
            Amount = Principal + Interest;
        }

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);

            if (IsAutoCompute)
                Compute();
        }


    }
}
