using MicrosoftStoreServicesAPI.V1.Common;

namespace MicrosoftStoreServicesAPI.V1.ApplicationList
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
