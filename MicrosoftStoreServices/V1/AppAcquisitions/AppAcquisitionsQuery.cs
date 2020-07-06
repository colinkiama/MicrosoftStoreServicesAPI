using WindowsStoreServices.V1.Common;

namespace WindowsStoreServices.V1.AppAcquisitions
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
