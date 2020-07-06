using MicrosoftStoreServicesAPI.OAuth;
using MicrosoftStoreServicesAPI.V1.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftStoreServices.V1.Acquisitions
{
    public class AcquisitionsQueryBuilder : OrderedQueryBuilder<AcquisitionsQueryBuilder, AcquisitionsQuery, Acquisition, AcquisitionsOrderBy>
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="AppAcquisitionsQueryBuilder"/> class.
        /// </summary>
        /// <param name="oauthToken">OAuth token</param>
        /// <param name="applicationId">The product ID of the app for which you want to retrieve acquisition data.</param>
        public AcquisitionsQueryBuilder(OAuthToken oauthToken, string applicationId)
            : base(oauthToken, applicationId)
        {
        }
    }
}
