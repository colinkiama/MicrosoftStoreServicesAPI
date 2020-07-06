using MicrosoftStoreServicesAPI.V1.Common;

namespace MicrosoftStoreServicesAPI.V1.ErrorReportingData
{
    /// <summary>
    /// Query for Error reporting data
    /// </summary>
    public class ErrorReportingDataQuery : OrderedGroupedQuery<ErrorReportingDataOrderBy, ErrorReportingDataGroupBy>
    {
        /// <summary>
        /// Gets the URL of the query
        /// </summary>
        public override string QueryName => "failurehits";
    }
}
