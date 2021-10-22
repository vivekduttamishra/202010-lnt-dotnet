using ConceptArchitect.BooksApi;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;







namespace Wpf08Resource
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			//book1Button.Resources["book"] = new Book
			//{
			//	Title = "The Accursed God",
			//	Author = "Vivek Dutta Mishra",
			//	Price = 399
			//}; 
			
			//book1Button.Resources["VisitedColor"] = Brushes.LightCoral;
		}

		
		private void ShowBook(object sender, RoutedEventArgs e)
		{
			//var button = sender as Button;

			var button = e.OriginalSource as Button;

			var book = button.Resources["book"] as Book;

			if (book != null)
			{
				MessageBox.Show(book.ToString(), "About Book", MessageBoxButton.OK, MessageBoxImage.Information);
				//var brush= button.Resources["VisitedColor"] as Brush; //Button doesn't have VisitedColor
				var brush = this.Resources["VisitedColor"] as Brush;

				if (brush!=null)					
					button.Background = brush;

			}
			else
            {
				MessageBox.Show("No Book Associated with this button", "Not Found", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}
	}
}
