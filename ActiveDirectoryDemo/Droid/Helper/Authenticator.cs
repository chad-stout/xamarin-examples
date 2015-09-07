using System;
using System.Linq;
using System.Runtime.CompilerServices;
using ActiveDirectoryDemo.Security;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Android.App;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(ActiveDirectoryDemo.Android.Helper.Authenticator))]
namespace ActiveDirectoryDemo.Android.Helper
{
	class Authenticator : IAuthenticator
	{
		public async Task<AuthenticationResult> Authenticate(string authority, string resource, string clientId, string returnUri)
		{
			var authContext = new AuthenticationContext(authority);
			if (authContext.TokenCache.ReadItems().Any())
				authContext = new AuthenticationContext(authContext.TokenCache.ReadItems().First().Authority);
			var uri = new Uri(returnUri);
			var platformParams = new PlatformParameters((MainActivity)Forms.Context);
			var authResult = await authContext.AcquireTokenAsync(resource, clientId, uri, platformParams);
			return authResult;
		}
	}
}