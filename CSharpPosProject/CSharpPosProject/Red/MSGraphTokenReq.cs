using System;
using System.Collections.Generic;
using System.IdentityModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.RootFinding;
using Microsoft.Identity.Client;

namespace CSharpPosProject.Red
{
    public class MSGraphTokenReq
    {
        string url_auth = "https://login.microsoftonline.com/6d391751-89fa-4d36-87f8-aef68a044707/oauth2/v2.0/authorize";
        private static string ClientId = "su_client_id";
        //private static string Tenant = "common";
        private static string Tenant = "su_tenant";
        string[] scopes = new string[] { "user.read" };
        public string getToken()
        {
            IPublicClientApplication publicClientApp = PublicClientApplicationBuilder.Create(ClientId)
                .WithRedirectUri("https://login.microsoftonline.com/common/oauth2/nativeclient")
                .WithAuthority(AzureCloudInstance.AzurePublic, Tenant)
            .Build();

            var authResult = publicClientApp.AcquireTokenInteractive(scopes)
                                      .ExecuteAsync();
            return authResult.Result.AccessToken;
        }
        public async Task<string> getTokenAsync()
        {
            IPublicClientApplication publicClientApp = PublicClientApplicationBuilder.Create(ClientId)
                .WithRedirectUri("https://login.microsoftonline.com/common/oauth2/nativeclient")
                .WithAuthority(AzureCloudInstance.AzurePublic, Tenant)
            .Build();

            var authResult = await publicClientApp.AcquireTokenInteractive(scopes)
                                      .ExecuteAsync();
            return authResult.AccessToken;
        }
    }
}
