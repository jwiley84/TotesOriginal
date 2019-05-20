﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotesOddityTravel.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TotesOddityTravel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewTravelPage : ContentPage
	{
		public NewTravelPage ()
		{
			InitializeComponent ();
		}

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Post post = new Post()
            {
                Experience = experienceEntry.Text
            };

            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<Post>();
            int rows = conn.Insert(post);
            conn.Close(); //never forget this line!

            if (rows > 0)
            {
                DisplayAlert("Success!", "Experience successfully inserted", "ok");
            }
            else
            {
                DisplayAlert("Failure", "OOPS! Something went wrong!", "ok");
            }
        }
    }
}