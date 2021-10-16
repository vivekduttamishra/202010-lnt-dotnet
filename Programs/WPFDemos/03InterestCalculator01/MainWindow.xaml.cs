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

namespace _03InterestCalculator01
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

        double GetValidValue(TextBox textBox)
        {
            String error = null;
            if (string.IsNullOrEmpty(textBox.Text))
                error = "Missing Value : ";



            double value;
            if (!double.TryParse(textBox.Text, out value))
                error = string.Format("Invalid Value : {0}  for ", textBox.Text);


            if (error != null)
            {
                //textBox.BackColor = Color.PaleVioletRed;
                throw new ArgumentException(error + textBox.Name.Replace("TextBox", ""));
            }
            else
            {
                //textBox.BackColor = Color.White;
                return value;
            }
        }

        private void calculateInterestButton_Click(object sender, EventArgs e)
        {

            try
            {
                var principal = GetValidValue(principalTextBox);
                var rate = GetValidValue(rateTextBox);
                var period = GetValidValue(periodTextBox);

                var interest = principal * rate * period / 1200;
                var amount = principal + interest;

                interestTextBox.Text = interest.ToString();
                amountTextBox.Text = amount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input");
            }




        }
    }
}
