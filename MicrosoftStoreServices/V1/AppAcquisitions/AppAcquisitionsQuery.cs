using MicrosoftStoreServicesAPI.V1.Common;

namespace MicrosoftStoreServicesAPI.V1.AppAcquisitions
{
    /// <summary>
    /// Query for App acquisition
    /// </summary>
    public class AppAcquisitionsQuery : OrderedQuery<AppAcquisitionsOrderBy>
    {
        /// <summary>
        /// Gets the URL of the query
        /// </summary>
        public override string QueryName => "appacquisitions";
    }
}
