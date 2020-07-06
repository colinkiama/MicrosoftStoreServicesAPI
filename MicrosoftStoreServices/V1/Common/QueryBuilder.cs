﻿using MicrosoftStoreServices.V1;
using MicrosoftStoreServices.V1.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MicrosoftStoreServicesAPI.OAuth;

namespace MicrosoftStoreServicesAPI.V1.Common
{



    /// <summary>
    /// Base Query Builder
    /// </summary>
    public abstract class QueryBuilder
    {

    }

    /// <summary>
    /// Base Query Builder
    /// </summary>
    /// <typeparam name="TQueryBuilder">QueryBuilder type</typeparam>
    /// <typeparam name="TQuery">Query type</typeparam>
    /// <typeparam name="TResult">Result type</typeparam>
    public abstract class QueryBuilder<TQueryBuilder, TQuery, TResult> : QueryBuilder
        where TQueryBuilder : QueryBuilder
        where TQuery : Query, new()
    {
        private const string BaseUrl = "https://manage.devcenter.microsoft.com/v1.0/my/analytics";


        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBuilder{TQueryBuilder,TQuery,TResult}"/> class.
        /// </summary>
        /// <param name="oauthToken">OAuth token</param>
        protected QueryBuilder(OAuthToken oauthToken)
        {
            OAuthToken = oauthToken;
            Query = new TQuery();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the OAuth token
        /// </summary>
        protected OAuthToken OAuthToken { get; set; }

        /// <summary>
        /// Gets or sets the query to build
        /// </summary>
        protected TQuery Query { get; set; }

        #endregion

        #region Methods

        //public async Task<IEnumerable<TResult>> GetResultsAsync()
        //{
        //    if (CheckIfHttpClientAuthHeaderNeedsToBeUpdated())
        //    {
        //        Client.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(OAuthToken.TokenType, OAuthToken.AccessToken);
        //    }

        //    var url = Query.GetUrl();
        //    var results = new List<TResult>();
        //    do
        //    {
        //        var uri = new Uri($"{BaseUrl}/{url}");
        //        var httpResponse = await Client.HttpClient.GetAsync(uri);
        //        var json = await httpResponse.Content.ReadAsStringAsync();

        //        var response = JsonConvert.DeserializeObject<Response<TResult>>(json);
        //        results.AddRange(response.Values);

        //        url = !string.IsNullOrEmpty(response.NextLink) ? response.NextLink : null;
        //    }
        //    while (!string.IsNullOrEmpty(url));

        //    return results.AsEnumerable();
        //}

        // New version
        public async Task<QueryResult<TResult>> GetResultsAsync()
        {
            if (CheckIfHttpClientAuthHeaderNeedsToBeUpdated())
            {
                Client.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(OAuthToken.TokenType, OAuthToken.AccessToken);
            }

            var url = Query.GetUrl();

            var uri = new Uri($"{BaseUrl}/{url}");
            var httpResponse = await Client.HttpClient.GetAsync(uri);
            var json = await httpResponse.Content.ReadAsStringAsync();

            var response = JsonConvert.DeserializeObject<Response<TResult>>(json);
            string nextPageUrl = !string.IsNullOrEmpty(response.NextLink) ? response.NextLink : null;
            QueryResult<TResult> queryResult = new QueryResult<TResult>(response.Values, nextPageUrl, BaseUrl, response.TotalCount);
            return queryResult;
        }

        private bool CheckIfHttpClientAuthHeaderNeedsToBeUpdated()
        {
            return Client.HttpClient.DefaultRequestHeaders.Authorization == null;
        }

        #endregion
    }
}
