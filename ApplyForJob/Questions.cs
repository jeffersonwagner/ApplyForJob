
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ApplyForJob.SendEmail;

namespace ApplyForJob
{
	[Activity (Label = "Questions")]			
	public class Questions : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Questions);

				


			button1.Click += delegate {
				StartActivity(typeof(Final));
				if (Convert.ToInt16(FindViewById<EditText1.Text>) >= 7 && Convert.ToInt16(FindViewById<EditText2.Text>) >= 7 && Convert.ToInt16(FindViewById<EditText3.Text>) >= 7)
				{
					int FrontEnd = 1;
					SendEmail.FrontEnd();
				}
				if (Convert.ToInt16(FindViewById<EditText4.Text>) >= 7 && Convert.ToInt16(EditText5.Text) >= 7)
				{
					int BackEnd = 1;
					SendEmail.BackEnd();
				}
				if (Convert.ToInt16(FindViewById<EditText6.Text>) >= 7 && Convert.ToInt16(FindViewById<EditText7.Text>) >= 7)
				{
					int Mobile = 1;
					SendMail.Mobile();
				}
				if (FrontEnd !=1 && BackEnd !=1 && Mobile !=1)
				{
					SendEmail.Generic();

			};
		}
	}
}

