using WindowsStoreServices.OAuth;
using WindowsStoreServices.V1.Common;

namespace WindowsStoreServices.V1.Ratings
{
    /// <summary>
    /// Query builder for ratings
    /// </summary>
    public class RatingsQueryBuilder : OrderedQueryBuilder<RatingsQueryBuilder, RatingsQuery, Rating, RatingsOrderBy>
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="RatingsQueryBuilder"/> class.
        /// </summary>
        /// <param name="oauthToken">OAuth token</param>
        /// <param name="applicationId">The product ID of the app for which you want to retrieve ratings.</param>
        public RatingsQueryBuilder(OAuthToken oauthToken, string applicationId)
            : base(oauthToken, applicationId)
        {
        }
    }
}
