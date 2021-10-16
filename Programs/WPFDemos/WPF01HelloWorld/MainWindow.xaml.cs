using ConceptArchitect.BooksApi;

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace WPF01HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();
            //SimpleObjectDemo();
            //DisplayUIElementWithContent();

            var book1 = new Book()   //Or some user defined object
            {
                Title = "The Accursed God",
                Author = "Vivek Dutta Mishra",
                Price = 399
            };

            var book2 = new Book()   //Or some user defined object
            {
                Title = "Rashmirathi",
                Author = "Ramdhari Singh Dinkar",
                Price = 150
            };

            var title = new Label() { Content = "Book List" };

            var book1Label = new Label() { Content = book1 };

            var book2Button = new Button() { Content = book2 };

            book2Button.Click += ShowBookInfo;

            var exitButton = new Button { Content = "Exit" };
            exitButton.Click += (sender, e) => Application.Current.Shutdown();

            //ListBox controls = CreateListBox(title, book1Label, book2Button, exitButton);

            //var panel = new StackPanel() { Orientation = Orientation.Horizontal };
            var panel = new UniformGrid() { Columns = 2 };

            AddChildrentToPanel(panel,title, book1Label, book2Button, exitButton);


           this.Content = panel;

        }

        private static void AddChildrentToPanel(Panel panel,Label title, Label book1Label, Button book2Button, Button exitButton)
        {
            panel.Children.Add(title);
            panel.Children.Add(book1Label);
            panel.Children.Add(book2Button);
            panel.Children.Add(exitButton);
        }

        private static ListBox CreateListBox(Label title, Label book1Label, Button book2Button, Button exitButton)
        {
            //How do I add three Items on the Window
            //Window can Accept a single content

            //Step 1. Create a Items Control
            var controls = new ListBox();

            //Step 2. Add All Controls to Items control
            controls.Items.Add(title);
            controls.Items.Add(book1Label);
            controls.Items.Add(book2Button);
            controls.Items.Add(exitButton);
            controls.Items.Add("End of List");

            //Step 3. Add the Items control to the window
            return controls;
        }

        void ShowBookInfo(object sender, EventArgs e)
        {
            dynamic button = sender;
            dynamic book = button.Content;
            var info = string.Format("Title:{0}\nAuthor:{1}\nPrice:  ₹ ${2}", book.Title, book.Author, book.Price);
            MessageBox.Show(info, "About the Book", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void DisplayUIElementWithContent()
        {
            //WPF Window can display one Content of type Object ---> any type
            //Not necessarily a WPF UI Element


           

            //We can add UI Element also

            TextBlock text1 = new TextBlock()
            {
                Text = "Welcome to WPF"
                //NO property to position or size the control
            };

            this.Content = text1;

            var book = new Book()   //Or some user defined object
            {
                Title = "The Accursed God",
                Author = "Vivek Dutta Mishra",
                Price = 399
            };

            //text1.Text = book; //can't assign object to TextBlock

            Label label1 = new Label();
            label1.Content = book;



            this.Content = label1;


            Button button = new Button();
            button.Content = book;
            button.Margin = new Thickness(10);

            button.Click += ShowBookInfo;
            this.Content = button;
        }

       

        private void SimpleObjectDemo()
        {
            this.Content = "Hello Wpf!"; //Simple String

            this.Content = 3.141592;  //value of PI

            this.Content = DateTime.Now;  //Or some other builtin object

            this.Content = new Book()   //Or some user defined object
            {
                Title = "The Accursed God",
                Author = "Vivek Dutta Mishra",
                Price = 399
            };
        }
    }
}
