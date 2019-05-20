using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeworkManager
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HamePage : ContentPage
	{
		public HamePage ()
		{
			InitializeComponent ();
		}

        private void ProjectsButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProjectPage());
        }

        private void TimerButton_Clicked(object sender, EventArgs e)
        {

        }

        private void AssignmentsButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}