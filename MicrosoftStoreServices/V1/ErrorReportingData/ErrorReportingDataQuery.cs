using WindowsStoreServices.V1.Common;

namespace WindowsStoreServices.V1.ErrorReportingData
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
