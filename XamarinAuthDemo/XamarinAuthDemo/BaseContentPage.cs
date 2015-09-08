using System;
using Xamarin.Forms;

namespace XamarinAuthDemo
{
	public class BaseContentPage : ContentPage
	{
		public BaseContentPage ()
		{
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();

			if (!App.IsLoggedIn) {
				Navigation.PushModalAsync(new LoginPage());
			}
		}
	}
}

