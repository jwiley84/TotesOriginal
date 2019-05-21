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
	public partial class ProjectPage : ContentPage
	{
		public ProjectPage ()
		{
			InitializeComponent ();
		}

        private void AddProjectItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewProjectPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<Project>(); //this might be the first place the table is seen, so just in case, create here.
            var posts = conn.Table<Project>().ToList();
            int pause = 0;
            conn.Close();
        }
    }
}