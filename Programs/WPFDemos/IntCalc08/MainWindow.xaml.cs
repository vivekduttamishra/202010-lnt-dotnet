using ConceptArchitect.Finance;
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

        private void CalculateInterest_Event(object sender, RoutedEventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            var calc = DataContext as SimpleInterestCalculator;
            calc.Compute();
        }

        private void CalculateCommand_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            Calculate();
        }

       

        private void CalculateCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            
            var calc = DataContext as SimpleInterestCalculator;

            //we can set can execute to true/false
            e.CanExecute = calc.IsValid;

        }
    }
}
