using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InterestCalculatorForm : Form
    {
        public InterestCalculatorForm()
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
                textBox.BackColor = Color.PaleVioletRed;
                throw new ArgumentException(error+textBox.Name.Replace("TextBox",""));
            }
            else
            {
                textBox.BackColor = Color.White;
                return value;
            }
        }
      
        private void calculateInterestButton_Click(object sender, EventArgs e)
        {

            try
            {
                var principal = GetValidValue(principalTextBox);
                // var rate = GetValidValue(rateTextBox);

                var rate = double.Parse(rateComboBox.SelectedText);

                var period = GetValidValue(periodTextBox);

                var interest = principal * rate * period / 1200;
                var amount = principal + interest;

                interestTextBox.Text = interest.ToString();
                amountTextBox.Text = amount.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
            
        }
    }
}
