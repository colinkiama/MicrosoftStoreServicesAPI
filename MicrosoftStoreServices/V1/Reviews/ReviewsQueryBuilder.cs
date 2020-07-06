using WindowsStoreServices.OAuth;
using WindowsStoreServices.V1.Common;

namespace WindowsStoreServices.V1.Reviews
{
    /// <summary>
    /// Query builder for reviews
    /// </summary>
    public class ReviewsQueryBuilder : OrderedQueryBuilder<ReviewsQueryBuilder, ReviewsQuery, Review, ReviewsOrderBy>
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="ReviewsQueryBuilder"/> class.
        /// </summary>
        /// <param name="oauthToken">OAuth token</param>
        /// <param name="applicationId">The product ID of the app for which you want to retrieve reviews.</param>
        public ReviewsQueryBuilder(OAuthToken oauthToken, string applicationId)
            : base(oauthToken, applicationId)
        {
        }
    }
}
