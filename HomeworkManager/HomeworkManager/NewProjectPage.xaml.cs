using HomeworkManager.Models;
using SQLite;
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
	public partial class NewProjectPage : ContentPage
	{
		public NewProjectPage ()
		{
			InitializeComponent ();
		}

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Project project = new Project()
            {
                Title = titleEntry.Text,
                Notes = notesEntry.Text,
                TestingDueDate = dueDateEntry.Text,
                IsFinished = false
            };

            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<Project>();
            int rows = conn.Insert(project);
            conn.Close(); //never forget this line!

            if (rows > 0)
            {
                DisplayAlert("Success!", "Assignment successfully inserted", "ok");
            }
            else
            {
                DisplayAlert("Failure", "OOPS! Something went wrong!", "ok");
            }
        }
    }
}