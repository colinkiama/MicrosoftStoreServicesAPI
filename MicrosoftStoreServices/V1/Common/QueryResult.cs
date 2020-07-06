using MicrosoftStoreServicesAPI.OAuth;
using MicrosoftStoreServicesAPI.V1.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftStoreServices.V1.Common
{
    public class QueryResult<T>
    {
        public string NextPageUrl { get; set; }
        public string QueryBaseUrl { get; set; }
        public IList<T> Results { get; set; }

        public int TotalCount { get; set; }

        public QueryResult()
        {

        }

        public QueryResult(IList<T> results, string nextPageUrl, string queryBaseUrl, int totalCount)
        {
            Results = results;
            NextPageUrl = nextPageUrl;
            QueryBaseUrl = queryBaseUrl;
            TotalCount = totalCount;
        }

        //public async Task<bool> LoadNextPageAsync(OAuthToken oAuthToken)
        //{
        //    bool wasNextPageLoaded = false;
        //    //bool isThereANextPage = !string.IsNullOrEmpty(QueryBaseUrl);

        //    //if (isThereANextPage)
        //    //{
        //    //    if (oAuthToken.HasExpired)
        //    //    {
        //    //        // Handle token expiry
        //    //    }
        //    //    if (CheckIfHttpClientAuthHeaderIsNotFilled())
        //    //    {
        //    //        //Client.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(oAuthToken.TokenType, oAuthToken.AccessToken);
        //    //    }



        //    //    var uri = new Uri($"{QueryBaseUrl}/{NextPageUrl}");
        //    //    var httpResponse = await Client.HttpClient.GetAsync(uri);
        //    //    var json = await httpResponse.Content.ReadAsStringAsync();

        //    //    var response = JsonConvert.DeserializeObject<Response<T>>(json);
        //    //    foreach (var item in response.Values)
        //    //    {
        //    //        Results.Add(item);
        //    //    }
                
        //    //    NextPageUrl = !string.IsNullOrEmpty(response.NextLink) ? response.NextLink : null;
        //    //    wasNextPageLoaded = true;
        //    //}
        //    return wasNextPageLoaded;
        //}

        //private bool CheckIfHttpClientAuthHeaderIsNotFilled()
        //{
        //    return Client.HttpClient.DefaultRequestHeaders.Authorization == null;
        //}
    }
}
