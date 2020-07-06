using WindowsStoreServices.V1.Common;

namespace WindowsStoreServices.V1.Reviews
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
