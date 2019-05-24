using HomeworkManager.Models;
using SQLite;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeworkManager
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewProjectPage : ContentPage
    {
        public NewProjectPage()
        {
            InitializeComponent();
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

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Project>();
                int rows = conn.Insert(project);

                if (rows > 0)
                {
                    DisplayAlert("Success!", "Assignment successfully inserted", "ok");
                    Navigation.PushAsync(new ProjectPage());
                }
                else
                {
                    DisplayAlert("Failure", "OOPS! Something went wrong!", "ok");
                }
            }


        }
    }
}