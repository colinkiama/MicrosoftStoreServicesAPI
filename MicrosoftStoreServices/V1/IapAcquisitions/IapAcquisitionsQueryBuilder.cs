using WindowsStoreServices.OAuth;
using WindowsStoreServices.V1.Common;

namespace WindowsStoreServices.V1.IapAcquisitions
{
    /// <summary>
    /// Query builder for IAP acquisitions
    /// </summary>
    public class IapAcquisitionsQueryBuilder : OrderedQueryBuilder<IapAcquisitionsQueryBuilder, IapAcquisitionsQuery, IapAcquisition, IapAcquisitionsOrderBy>
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="IapAcquisitionsQueryBuilder"/> class.
        /// </summary>
        /// <param name="oauthToken">OAuth token</param>
        /// <param name="applicationId">The product ID of the app for which you want to retrieve acquisition data.</param>
        /// <param name="inAppProductId">The product ID of the IAP for which you want to retrieve acquisition data.</param>
        public IapAcquisitionsQueryBuilder(OAuthToken oauthToken, string applicationId, string inAppProductId)
            : base(oauthToken, applicationId)
        {
            Query = new IapAcquisitionsQuery()
            {
                ApplicationId = applicationId,
                InAppProductId = inAppProductId
            };
        }
    }
}
