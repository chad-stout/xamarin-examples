using System;
using Xamarin.Forms;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using ActiveDirectoryDemo.Security;

namespace ActiveDirectoryDemo
{
	public class HomePage : ContentPage
	{
		public static string clientId = "XXXXXXXXXXXXXXX";
		public static string authority = "https://login.windows.net/common";
		public static string returnUri = "https://login.live.com/oauth20_desktop.srf";
		private const string graphResourceUri = "https://graph.windows.net";
		private AuthenticationResult authResult = null;

		public HomePage ()
		{
			Content = new StackLayout
			{
				Children = {

					LoginButton()

				}
			};

		}

		private Button LoginButton()
		{
			var result =  new Button
			{
				Text = "Login",
			};

			result.Clicked += LoginClicked;

			return result;
		}

		private async void LoginClicked(object sender, EventArgs e)
		{
			var auth = DependencyService.Get<IAuthenticator>();
			var data = await auth.Authenticate(authority, graphResourceUri, clientId, returnUri);
			var userName = data.UserInfo.GivenName + " " + data.UserInfo.FamilyName;
			await DisplayAlert("Token", userName, "Ok", "Cancel");
		}



	}
}

