using System;
using Xamarin.Forms;

namespace XamarinFrameworkApp
{
    public partial class MainPage : ContentPage
    {
        #region trash for wtf is wrong
        //private string greetingLabel;
        #endregion

        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this is the method that is called when 'Botton_Clicked' on the .xaml file is referenced
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Button_Clicked(object sender, EventArgs e)
        {
            greetingLabel.Text = "Hello World! Welcome " + nameEntry.Text;
        }
    }
}
