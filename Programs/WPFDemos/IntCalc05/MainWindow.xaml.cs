using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IntCalc01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public double Principal
        {
            get { return (double)GetValue(PrincipalProperty); }
            set { SetValue(PrincipalProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Principal.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PrincipalProperty =
            DependencyProperty.Register("Principal", typeof(double), typeof(MainWindow), new PropertyMetadata(0.0));



        public double Rate
        {
            get { return (double)GetValue(RateProperty); }
            set { SetValue(RateProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Rate.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RateProperty =
            DependencyProperty.Register("Rate", typeof(double), typeof(MainWindow), new PropertyMetadata(0.0));





        public int Period
        {
            get { return (int)GetValue(PeriodProperty); }
            set { SetValue(PeriodProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Period.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PeriodProperty =
            DependencyProperty.Register("Period", typeof(int), typeof(MainWindow), new PropertyMetadata(12));





        public double Interest
        {
            get { return (double)GetValue(InterestProperty); }
            set { SetValue(InterestProperty, value); }
        }

      
        public static readonly DependencyProperty InterestProperty =
            DependencyProperty.Register("Interest", typeof(double), typeof(MainWindow), new PropertyMetadata(0.0));


        public double Amount
        {
            get { return (double)GetValue(AmountProperty); }
            set { SetValue(AmountProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Amount.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AmountProperty =
            DependencyProperty.Register("Amount", typeof(double), typeof(MainWindow), new PropertyMetadata(0.0));




        public bool IsAutoCompute
        {
            get { return (bool)GetValue(IsAutoComputeProperty); }
            set { SetValue(IsAutoComputeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsAutoCompute.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsAutoComputeProperty =
            DependencyProperty.Register("IsAutoCompute", typeof(bool), typeof(MainWindow), new PropertyMetadata(false));






        public MainWindow()
        {
            
            //Period = 24;
            this.DataContext = this;
            InitializeComponent();


            //even after intialization
            Principal = 20000; //will notify and update the UI
            Rate = 10;


        }


        private void CalculateInterest(object sender, RoutedEventArgs e)
        {

            Interest = Principal * Rate * Period / 1200;
            Amount = Principal + Interest;

        }

        private void HandleTextChange(object sender, RoutedEventArgs e)
        {
            if (IsAutoCompute)
                Compute();
        }

        private void Compute()
        {
            Interest = Principal * Rate * Period / 1200;
            Amount = Principal + Interest;
        }

       
    }
}
