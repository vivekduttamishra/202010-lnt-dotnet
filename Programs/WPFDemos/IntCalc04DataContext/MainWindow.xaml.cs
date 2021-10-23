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
        public double Principal { get; set; }
        public double Rate { get; set; }
        public int Period { get; set; }

        //public double Interest { get; set; }

        public double Interest
        {
            get { return (double)GetValue(InterestProperty); }
            set { SetValue(InterestProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Interest.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InterestProperty =
            DependencyProperty.Register("Interest", typeof(double), typeof(MainWindow), new PropertyMetadata(0.0));



        //public double Amount { get; set; }



        public double Amount
        {
            get { return (double)GetValue(AmountProperty); }
            set { SetValue(AmountProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Amount.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AmountProperty =
            DependencyProperty.Register("Amount", typeof(double), typeof(MainWindow), new PropertyMetadata(0.0));




        private void CalculateInterest(object sender, RoutedEventArgs e)
        {   
            Interest = Principal * Rate * Period / 1200;
            Amount = Principal + Interest;
        }




        public MainWindow()
        {
            Principal = 20000;
            Rate = 10;
            Period = 36;
            this.DataContext = this;
            InitializeComponent();
        }

        //T GetValue<T>(TextBox textBox)
        //{
        //    var name = textBox.Name.Replace("TextBox", "");
        //    var value = textBox.Text;
        //    try
        //    {
               
        //        if (string.IsNullOrEmpty(value))
        //            throw new ArgumentException(string.Format("Missing value for '{0}'", name));
        //        return (T)Convert.ChangeType(value, typeof(T));
        //    }catch(FormatException ex)
        //    {
        //        throw new ArgumentException(string.Format("Invalid Value for {0} : {1}", name, value));
        //    }
            
        //}

        //private void CalculateInterest(object sender, RoutedEventArgs e)
        //{
          
        //    //Automatically Updated When Target UIElement Changes because of Binding
        //    //Principal = GetValue<double>(principalTextBox);
        //    //Rate = GetValue<double>(rateTextBox);
        //    //Period = GetValue<int>(periodTextBox);

        //    Interest = Principal * Rate * Period / 1200;
        //    Amount = Principal + Interest;

        //    //Should Automatically Update When Source Element (DataContext) changes
        //    //interestTextBox.Text = Interest.ToString();
        //    //amountTextBox.Text = Amount.ToString();
        //    //statusLabel.Text = "done";
          

        //}
    }
}
