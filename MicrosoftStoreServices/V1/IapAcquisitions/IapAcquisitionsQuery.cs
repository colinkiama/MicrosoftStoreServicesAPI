using Newtonsoft.Json;
using WindowsStoreServices.V1.Common;

namespace WindowsStoreServices.V1.IapAcquisitions
{
    /// <summary>
    /// Query for IAP acquisition
    /// </summary>
    public class IapAcquisitionsQuery : OrderedQuery<IapAcquisitionsOrderBy>
    {
        /// <summary>
        /// Gets the URL of the query
        /// </summary>
        public override string QueryName => "iapacquisitions";

        /// <summary>
        /// Gets tor sets the product ID of the IAP for which you want to retrieve acquisition data.
        /// </summary>
        [JsonProperty("inAppProductId")]
        public string InAppProductId { get; set; }

        /// <summary>
        /// Create the URL for the query
        /// </summary>
        /// <returns>The generated URL</returns>
        public override string GetUrl()
        {
            var uri = base.GetUrl();

            uri = $"{uri}&inAppProductId={InAppProductId}";

            return uri;
        }
    }
}
