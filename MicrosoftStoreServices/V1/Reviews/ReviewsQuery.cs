using MicrosoftStoreServicesAPI.V1.Common;

namespace MicrosoftStoreServicesAPI.V1.Reviews
{
    /// <summary>
    /// Query for reviews
    /// </summary>
    public class ReviewsQuery : OrderedQuery<ReviewsOrderBy>
    {
        /// <summary>
        /// Gets the URL of the query
        /// </summary>
        public override string QueryName => "reviews";
    }
}
