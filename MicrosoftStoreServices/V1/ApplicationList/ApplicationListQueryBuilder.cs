using MicrosoftStoreServicesAPI.OAuth;
using MicrosoftStoreServicesAPI.V1.Common;

namespace MicrosoftStoreServicesAPI.V1.ApplicationList
{
    /// <summary>
    /// Query builder for application list
    /// </summary>
    public class ApplicationListQueryBuilder : QueryBuilder<ApplicationListQueryBuilder, ApplicationListQuery, Application>
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="ApplicationListQueryBuilder"/> class.
        /// </summary>
        /// <param name="oauthToken">OAuth token</param>
        public ApplicationListQueryBuilder(OAuthToken oauthToken)
            : base(oauthToken)
        {
        }
    }
}
