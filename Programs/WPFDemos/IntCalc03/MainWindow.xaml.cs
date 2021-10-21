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


        public MainWindow()
        {
            InitializeComponent();
        }

        T GetValue<T>(TextBox textBox)
        {
            var name = textBox.Name.Replace("TextBox", "");
            var value = textBox.Text;
            try
            {
               
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException(string.Format("Missing value for '{0}'", name));
                return (T)Convert.ChangeType(value, typeof(T));
            }catch(FormatException ex)
            {
                throw new ArgumentException(string.Format("Invalid Value for {0} : {1}", name, value));
            }
            
        }

        private void CalculateInterest(object sender, RoutedEventArgs e)
        {
            try
            {
                double principal = GetValue<double>(principalTextBox);
                double rate = GetValue<double>(rateTextBox);
                int period = GetValue<int>(periodTextBox);

                double interest = principal * rate * period / 1200;
                double amount = principal + interest;

                interestTextBox.Text = interest.ToString();
                amountTextBox.Text = amount.ToString();
                statusLabel.Text = "done";
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }            

        }
    }
}
