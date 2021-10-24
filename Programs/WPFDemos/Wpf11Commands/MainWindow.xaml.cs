using ConceptArchitect.TaskApi;
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

        TaskManager manager;
        public MainWindow()
        {
            InitializeComponent();
            manager = DataContext as TaskManager;
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
            
            manager.CreateNewTask();
        }

        private void SaveCommand(object sender, ExecutedRoutedEventArgs e)
        {
            manager.AddTask();
        }

        private void DeleteTaskCommand(object sender, ExecutedRoutedEventArgs e)
        {
            var response=MessageBox.Show(manager.CurrentTask.Title, "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if(response==MessageBoxResult.Yes)
            {
                manager.RemoveTask();
            }
        }

        private void CanDelete(object sender, CanExecuteRoutedEventArgs e)
        {
            if(manager!=null)
                e.CanExecute = manager.CurrentTask != null && !manager.IsNew;
        }
    }
}
