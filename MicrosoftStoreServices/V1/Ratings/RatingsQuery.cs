using MicrosoftStoreServicesAPI.V1.Common;

namespace MicrosoftStoreServicesAPI.V1.Ratings
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