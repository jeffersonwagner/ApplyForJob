using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace ApplyForJob
{
	[Activity (Label = "ApplyForJob", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity

	{
		public string nome;
		public string email;
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button1 = FindViewById<Button1> (Resource.Id.myButton);
			
			button1.Click += delegate {
				nome = FindViewById<editText1.Text>;
				email = FindViewById<editText2.Text>;
				StartActivity(typeof(Questions));
			};
		}
	}
}


