using System.Collections.Generic;
using WindowsStoreServices.OAuth;

namespace WindowsStoreServices.V1.Common
{
    public class OrderedGroupedQueryBuilder<TQueryBuilder, TQuery, TResult, TOrderBy, TGroupBy> : OrderedQueryBuilder<TQueryBuilder, TQuery, TResult, TOrderBy>
        where TQueryBuilder : OrderedQueryBuilder<TQueryBuilder, TQuery, TResult, TOrderBy>
        where TQuery : OrderedGroupedQuery<TOrderBy, TGroupBy>, new()
        where TOrderBy : struct
        where TGroupBy : struct
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="OrderedGroupedQueryBuilder{TQueryBuilder,TQuery,TResult,TOrderBy,TGroupBy}"/> class.
        /// </summary>
        /// <param name="oauthToken">OAuth token</param>
        /// <param name="applicationId">The product ID of the app for which you want to retrieve data.</param>
        public OrderedGroupedQueryBuilder(OAuthToken oauthToken, string applicationId)
            : base(oauthToken, applicationId)
        {
            Query.GroupBy = new List<TGroupBy>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupByValue"></param>
        /// <returns></returns>
        public TQueryBuilder GroupBy(TGroupBy groupByValue)
        {
            Query.GroupBy = new List<TGroupBy>()
            {
                groupByValue
            };
            return this as TQueryBuilder;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupByValue"></param>
        /// <returns></returns>
        public TQueryBuilder ThenGroupBy(TGroupBy groupByValue)
        {
            Query.GroupBy.Add(groupByValue);
            return this as TQueryBuilder;
        }
    }
}
