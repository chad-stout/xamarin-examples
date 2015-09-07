using System;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Threading.Tasks;

namespace ActiveDirectoryDemo.Security
{
	public interface IAuthenticator
	{
		Task<AuthenticationResult> Authenticate(string authority, string resource, string clientId, string returnUri);
	}
}