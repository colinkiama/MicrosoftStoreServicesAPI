using Newtonsoft.Json;

namespace WindowsStoreServices.V1.ApplicationList
{
    /// <summary>
    /// Application
    /// </summary>
    public class Application
    {
        /// <summary>
        /// Gets the product ID of the app.
        /// </summary>
        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets the display name of the app.
        /// </summary>
        [JsonProperty("applicationName")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Gets the unique identifier of the publisher.
        /// </summary>
        [JsonProperty("publisherId")]
        public string PublisherId { get; set; }

        /// <summary>
        /// Gets the URL for the icon
        /// </summary>
        [JsonProperty("iconURLList")]
        public string IconURLList { get; set; }
        
        /// <summary>
        /// Gets the display name of the publisher.
        /// </summary>
        [JsonProperty("publisherName")]
        public string PublisherName { get; set; }

        /// <summary>
        /// Gets the package family name.
        /// </summary>
        [JsonProperty("packageFamilyName")]
        public string PackageFamilyName { get; set; }

        /// <summary>
        /// Gets the package identity name.
        /// </summary>
        [JsonProperty("packageIdentityName")]
        public string PackageIdentityName { get; set; }
    }
}
