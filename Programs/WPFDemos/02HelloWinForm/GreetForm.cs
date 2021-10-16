using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02HelloWinForm
{
    public class GreetForm: Form
    {
        TextBox nameTextBox;
        Button greetButton, clearButton, exitButton;
        

        public GreetForm()
        {
            //Form Properties
            this.Text = "Greeter";
            this.FormClosing += GreetForm_FormClosing;
            
            

            //MyControls

            Label label = new Label()
            {
                Text = "Please Enter Your Name",
                Location = new Point(50, 10),
                Size = new Size(200, 30)
            };
            this.Controls.Add(label); //add the label to the window


            nameTextBox = new TextBox()
            {
                Location = new Point(50, 50),
                Size = new Size(130, 30)
            };

            this.Controls.Add(nameTextBox);


            greetButton = new Button()
            {
                Location = new Point(50, 90),
                Size = new Size(60, 30),
                Text = "Greet"
            };

            this.Controls.Add(greetButton);

            clearButton = new Button()
            {
                Location = new Point(120, 90),
                Size = new Size(60, 30),
                Text = "Clear"
            };

            this.Controls.Add(clearButton);

            exitButton = new Button()
            {
                Text = "X",
                Size = new Size(20, 20),
                BackColor = Color.Red,
                ForeColor = Color.White,
                Location = new Point(this.Width - 40, 0)
            };

            this.Controls.Add(exitButton);


            //How to Handle Events

            greetButton.Click += GreetUser; //mapped to an external function


            clearButton.Click += (sender, e) => nameTextBox.Text = "";


            exitButton.Click += ExitButton_Click;



        }

        private void GreetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ConfirmExit())
            {
                //user doesn't want to the window to be closed. So cancle this action
                e.Cancel = true; //cancle the close action
            }
        }

        bool ConfirmExit()
        {
            if (MessageBox.Show("Are you sure you want to exit", "Confirm Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); //exit the GUI Application
                return true;
            }
            else
                return false;
                

           
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            
            ConfirmExit();  
        }

        void GreetUser(object sender, EventArgs e)
        {
            string greeting = null;
            MessageBoxIcon icon = MessageBoxIcon.Information;
           if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                greeting = "Hey Stranger! Do you have name?";
                icon = MessageBoxIcon.Question;
            }
                
            else
                greeting = string.Format("Hello {0}\nWelcome to Our Application", nameTextBox.Text);


            MessageBox.Show(greeting, "Greetings", MessageBoxButtons.OK, icon);


        }
    }
}
