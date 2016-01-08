using Android.App;
using Android.Widget;
using Android.OS;

using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Support.V4.App;

using Android.Gms.Maps;
using Android.Gms.Maps.Model;

using System;

namespace DroidMap
{
	[Activity (Label = "DroidMap", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle savedInstanceState)
		{
			Xamarin.Insights.Initialize (XamarinInsights.ApiKey, this);
			base.OnCreate (savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			// Get our button from the layout resource,
			// and attach an event to it
		}
	}
}
