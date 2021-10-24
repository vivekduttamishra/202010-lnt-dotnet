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

namespace Wpf11Commands
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

        private void HelpCommand(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Task Manager V1", "About Task Manager", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void CloseApp(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Closing Application");
        }

        private void NewTaskCommand(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("New Task Created");
        }

        private void SaveCommand(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Saved");
        }
    }
}
