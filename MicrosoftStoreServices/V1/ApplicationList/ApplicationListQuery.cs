using WindowsStoreServices.V1.Common;

namespace WindowsStoreServices.V1.ApplicationList
{
    /// <summary>
    /// Query for Application list
    /// </summary>
    public class ApplicationListQuery : Query
    {
        /// <summary>
        /// Gets the URL of the query
        /// </summary>
        public override string QueryName => "applicationlist";
    }
}
