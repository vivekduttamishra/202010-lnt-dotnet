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

namespace Wpf05ColorPreviewApp01
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



        private void UpdatePreview()
        {
            //previewBox.Background = new SolidColorBrush(Color.FromRgb(251, 151, 51));

            previewBox.Background = GetNamedColor(colorNameTextBox.Text);

        }

        private Brush GetNamedColor(string text)
        {
            Brush defaultBrush = Brushes.Transparent;//Brushes.White;
            if (string.IsNullOrEmpty(text))
                return defaultBrush;

            switch (text.ToLower())
            {
                case "red": return Brushes.Red;
                case "green": return Brushes.Green;
                case "blue":return Brushes.Blue;
                case "black": return Brushes.Black;
                case "white": return Brushes.White;
            }

            return defaultBrush;
        }

        private void HandleUpdatePreview(object sender, RoutedEventArgs e)
        {
            UpdatePreview();
        }

        private void OnCheckChange(object sender, RoutedEventArgs e)
        {
            previewButton.IsEnabled = !autoPreviewCheckBox.IsChecked.Value;  //Is Checked is nullble boolean. Can have value true/false/null
            UpdatePreview();
        }

        private void OnColorNameChange(object sender, TextChangedEventArgs e)
        {
            if (autoPreviewCheckBox.IsChecked.Value)
                UpdatePreview();
        }
    }
}
