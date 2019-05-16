using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HomeworkManager
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            bool isUserNameEmpty = string.IsNullOrEmpty(usernameEntry.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);


            if (isPasswordEmpty && isUserNameEmpty)
            {
                welcomeLabel.Text = "What kind of shenanigans are you up to?";
            }
            else if (isUserNameEmpty && !isPasswordEmpty)
            {
                welcomeLabel.Text = "You gotta put a user name in, first";
            }
            else if (isPasswordEmpty && !isUserNameEmpty)
            {
                welcomeLabel.Text = "You need a password, genius";
            }
            else if (usernameEntry.Text == "JJ" && passwordEntry.Text == "123")
            {
                welcomeLabel.Text = "Welcome, " + usernameEntry.Text + "!";
                Navigation.PushAsync(new HomePage());
            }
        }
    }
}
