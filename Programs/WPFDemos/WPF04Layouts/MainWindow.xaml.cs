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

namespace WPF04Layouts
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

        private void ShowStackPanelDemo(object sender, RoutedEventArgs e)
        {
            var win = new StackPanelDemo();
            win.Show();

        }

        private void ShowUniformGridDemo(object sender, RoutedEventArgs e)
        {
            var win = new UniformGridDemo();
            win.Show();
        }

        private void ShowDockPanelDemo(object sender, RoutedEventArgs e)
        {
            var win = new DockPanelDemo();
            win.Show();
        }
    }
}
