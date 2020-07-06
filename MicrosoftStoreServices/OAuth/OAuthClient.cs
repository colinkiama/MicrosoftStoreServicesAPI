using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsStoreServices.OAuth
{
    public class OAuthClient : IOAuthClient
    {
        public async Task<OAuthToken> GetTokenAsync(string tenantId, string clientId, string clientSecret)
        {
            var values = new Dictionary<string, string>()
            {
                { "grant_type", "client_credentials" },
                { "client_id", clientId },
                { "client_secret", clientSecret },
                { "resource", "https://manage.devcenter.microsoft.com" },
            };

            var httpClient = new HttpClient();
            var response = await httpClient.PostAsync(new Uri($"https://login.microsoftonline.com/{tenantId}/oauth2/token"), new FormUrlEncodedContent(values));

            return JsonConvert.DeserializeObject<OAuthToken>(await response.Content.ReadAsStringAsync());
        }
    }
}
