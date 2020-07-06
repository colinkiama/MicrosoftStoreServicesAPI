using System;
using System.Collections.Generic;
using WindowsStoreServices.OAuth;
using WindowsStoreServices.V1.Common.Enums;

namespace WindowsStoreServices.V1.Common
{
    public class OrderedQueryBuilder<TQueryBuilder, TQuery, TResult, TOrderBy> : QueryBuilder<TQueryBuilder, TQuery, TResult>
        where TQueryBuilder : QueryBuilder<TQueryBuilder, TQuery, TResult>
        where TQuery : OrderedQuery<TOrderBy>, new()
        where TOrderBy : struct
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBuilder{TQueryBuilder,TQuery,TResult,TOrderByFields}"/> class.
        /// </summary>
        /// <param name="oauthToken">OAuth token</param>
        /// <param name="applicationId">Application Id</param>
        protected OrderedQueryBuilder(OAuthToken oauthToken, string applicationId)
            : base(oauthToken)
        {
            Query = new TQuery()
            {
                ApplicationId = applicationId
            };
        }

        #endregion

        #region Methods

        /// <summary>
        /// Aggregate results by the specified level
        /// </summary>
        /// <param name="value">Aggregation level</param>
        /// <returns></returns>
        public TQueryBuilder AggregateBy(AggregationLevels value)
        {
            Query.AggregationLevel = value;
            return this as TQueryBuilder;
        }

        /// <summary>
        /// Filter results on a date range
        /// </summary>
        /// <param name="startDate">Start date</param>
        /// <param name="endDateTime">End date</param>
        /// <returns></returns>
        public TQueryBuilder Between(DateTime startDate, DateTime endDateTime)
        {
            Query.StartDate = startDate;
            Query.EndDate = endDateTime;
            return this as TQueryBuilder;
        }

        /// <summary>
        /// Set the number of rows to skip
        /// </summary>
        /// <param name="value">Number of results to skip</param>
        /// <returns></returns>
        public TQueryBuilder Skip(int? value)
        {
            Query.Skip = value;
            return this as TQueryBuilder;
        }

        /// <summary>
        /// Set the number of rows to retrieve
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public TQueryBuilder Take(int? value)
        {
            Query.Top = value;
            return this as TQueryBuilder;
        }

        public TQueryBuilder OrderBy(TOrderBy orderByValue, OrderByDirections orderByDirection = OrderByDirections.Ascending)
        {
            Query.OrderBy = new List<Tuple<TOrderBy, OrderByDirections>>()
            {
                Tuple.Create(orderByValue, orderByDirection)
            };
            return this as TQueryBuilder;
        }

        public TQueryBuilder ThenOrderBy(TOrderBy orderByValue, OrderByDirections orderByDirection = OrderByDirections.Ascending)
        {
            Query.OrderBy.Add(Tuple.Create(orderByValue, orderByDirection));
            return this as TQueryBuilder;
        }

        #endregion
    }
}
