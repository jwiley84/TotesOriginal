using HomeworkManager.Models;
using SQLite;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeworkManager
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectPage : ContentPage
    {
        public ProjectPage()
        {
            InitializeComponent();
        }

        private void AddProjectItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewProjectPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Project>(); //this might be the first place the table is seen, so just in case, create here.
                var projects = conn.Table<Project>().ToList();
                projectListView.ItemsSource = projects;
            }

        }
    }
}