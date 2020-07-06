using WindowsStoreServices.V1.Common;

namespace WindowsStoreServices.V1.Ratings
{
    /// <summary>
    /// Query for ratings
    /// </summary>
    public class RatingsQuery : OrderedQuery<RatingsOrderBy>
    {
        /// <summary>
        /// Gets the URL of the query
        /// </summary>
        public override string QueryName => "ratings";
    }
}