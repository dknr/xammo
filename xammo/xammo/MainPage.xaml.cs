using System;
using System.Collections.Generic;
using System.Linq;
using Android.Widget;
using Xamarin.Forms;
using Xammo.Droid;

namespace Xammo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        Toast.MakeText(Forms.Context, "This is a toast message!", ToastLength.Short).Show();
            Navigation.PushAsync(new OtherPage());
	    }
	}
}
