using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;
using BackgroundStreamingAudio.Services;


namespace Mambo.Android
{
	[Activity (Label = "Mambo", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : AndroidActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			Xamarin.Forms.Forms.Init (this, bundle);

			var mambo = new Mambo ();
			mambo.RestartButton.Clicked += HandleClicked;

			SetPage (mambo.MamboPage);


			SendAudioCommand(MamboService.ActionPlay);
		}

		private void SendAudioCommand(string action)
		{
			var intent = new Intent(action);
			StartService(intent);
		}

		void HandleClicked (object sender, EventArgs e)
		{
			SendAudioCommand(MamboService.ActionStop);
			SendAudioCommand(MamboService.ActionPlay);
		}
	}
}

