using MicrosoftStoreServicesAPI.OAuth;
using MicrosoftStoreServicesAPI.V1.Common;

namespace MicrosoftStoreServicesAPI.V1.ErrorReportingData
{
    /// <summary>
    /// Query builder for error reporting data
    /// </summary>
    public class ErrorReportingDataQueryBuilder
        : OrderedGroupedQueryBuilder<ErrorReportingDataQueryBuilder, ErrorReportingDataQuery, ErrorReportingDataItem, ErrorReportingDataOrderBy, ErrorReportingDataGroupBy>
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="ErrorReportingDataQueryBuilder"/> class.
        /// </summary>
        /// <param name="oauthToken">OAuth token</param>
        /// <param name="applicationId">The product ID of the app for which you want to retrieve error reporting data.</param>
        public ErrorReportingDataQueryBuilder(OAuthToken oauthToken, string applicationId)
            : base(oauthToken, applicationId)
        {
        }
    }
}
