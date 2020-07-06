using WindowsStoreServices.OAuth;
using WindowsStoreServices.V1.Common;

namespace WindowsStoreServices.V1.AppAcquisitions
{
    /// <summary>
    /// Query builder for app acquisition
    /// </summary>
    public class AppAcquisitionsQueryBuilder : OrderedQueryBuilder<AppAcquisitionsQueryBuilder, AppAcquisitionsQuery, AppAcquisition, AppAcquisitionsOrderBy>
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="AppAcquisitionsQueryBuilder"/> class.
        /// </summary>
        /// <param name="oauthToken">OAuth token</param>
        /// <param name="applicationId">The product ID of the app for which you want to retrieve acquisition data.</param>
        public AppAcquisitionsQueryBuilder(OAuthToken oauthToken, string applicationId)
            : base(oauthToken, applicationId)
        {
        }
    }
}
