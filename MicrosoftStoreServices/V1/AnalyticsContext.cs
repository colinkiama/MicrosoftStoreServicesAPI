using System;
using MicrosoftStoreServicesAPI.OAuth;
using MicrosoftStoreServicesAPI.V1.AppAcquisitions;
using MicrosoftStoreServicesAPI.V1.ApplicationList;
using MicrosoftStoreServicesAPI.V1.ErrorReportingData;
using MicrosoftStoreServicesAPI.V1.IapAcquisitions;
using MicrosoftStoreServicesAPI.V1.Ratings;
using MicrosoftStoreServicesAPI.V1.Reviews;

namespace MicrosoftStoreServicesAPI.V1
{
    /// <summary>
    /// Data context for the Analytics API
    /// </summary>
    public class AnalyticsContext
    {
        #region Fields

        /// <summary>
        /// The OAuth token associated to this context
        /// </summary>
        private OAuthToken _token;

        #endregion

        #region Constructors

        /// <summary>
        /// Initialize a new instance of the <see cref="AnalyticsContext"/> class.
        /// </summary>
        public AnalyticsContext()
        {

        }

        /// <summary>
        /// Initialize a new instance of the <see cref="AnalyticsContext"/> class.
        /// </summary>
        /// <param name="token">OAuth token</param>
        public AnalyticsContext(OAuthToken token)
        {
            _token = token;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Set the OAuth token
        /// </summary>
        /// <param name="token">OAuth token</param>
        public void SetOAuthToken(OAuthToken token)
        {
            _token = token;
        }

        /// <summary>
        /// Get an aggregate acquisition data for an application during a given date range and other optional filters.
        /// </summary>
        /// <param name="applicationId">The product ID of the app for which you want to retrieve acquisition data.</param>
        /// <returns>An instance of <see cref="AppAcquisitionsQueryBuilder"/> to build the query</returns>
        public AppAcquisitionsQueryBuilder AppAcquisitions(string applicationId)
        {
            CheckOAuthToken();
            return new AppAcquisitionsQueryBuilder(_token, applicationId);
        }

        /// <summary>
        /// Get all applications associated to the authentified account.
        /// </summary>
        /// <returns>An instance of <see cref="ApplicationListQueryBuilder"/> to build the query</returns>
        public ApplicationListQueryBuilder Applications()
        {
            CheckOAuthToken();
            return new ApplicationListQueryBuilder(_token);
        }

        /// <summary>
        /// Get aggregate error reporting data for a given date range and other optional filters.
        /// </summary>
        /// <param name="applicationId">The product ID of the app for which you want to retrieve error reporting data.</param>
        /// <returns>An instance of <see cref="ErrorReportingDataQueryBuilder"/> to build the query</returns>
        public ErrorReportingDataQueryBuilder ErrorReportingData(string applicationId)
        {
            CheckOAuthToken();
            return new ErrorReportingDataQueryBuilder(_token, applicationId);
        }

        /// <summary>
        /// Get aggregate acquisition data for an in-app product (IAP) during a given date range and other optional filters.
        /// </summary>
        /// <param name="applicationId">The product ID of the app for which you want to retrieve IAP acquisition data.</param>
        /// <returns>An instance of <see cref="IapAcquisitionsQueryBuilder"/> to build the query</returns>
        public IapAcquisitionsQueryBuilder IapAcquisitions(string applicationId, string inAppProductId)
        {
            CheckOAuthToken();
            return new IapAcquisitionsQueryBuilder(_token, applicationId, inAppProductId);
        }

        /// <summary>
        /// Get aggregate ratings data for a given date range and other optional filters.
        /// </summary>
        /// <param name="applicationId">The product ID of the app for which you want to retrieve ratings data.</param>
        /// <returns>An instance of <see cref="RatingsQueryBuilder"/> to build the query</returns>
        public RatingsQueryBuilder Ratings(string applicationId)
        {
            CheckOAuthToken();
            return new RatingsQueryBuilder(_token, applicationId);
        }

        /// <summary>
        /// Get review data for a given date range and other optional filters.
        /// </summary>
        /// <param name="applicationId">The product ID of the app for which you want to retrieve review data.</param>
        /// <returns>An instance of <see cref="ReviewsQueryBuilder"/> to build the query</returns>
        public ReviewsQueryBuilder Reviews(string applicationId)
        {
            CheckOAuthToken();
            return new ReviewsQueryBuilder(_token, applicationId);
        }

        /// <summary>
        /// Check if the OAuth token is present
        /// </summary>
        private void CheckOAuthToken()
        {
            if (_token == null)
                throw new OAuthTokenMissingException();
        }
        #endregion
    }
}
