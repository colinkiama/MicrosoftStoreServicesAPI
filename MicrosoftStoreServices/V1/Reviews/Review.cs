using Newtonsoft.Json;
using System;
using WindowsStoreServices.V1.Common.Enums;

namespace WindowsStoreServices.V1.Reviews
{
    /// <summary>
    /// Review data
    /// </summary>
    public class Review
    {
        /// <summary>
        /// Gets the first date in the date range for the ratings data.
        /// If the request specified a single day, this value is that date.
        /// If the request specified a week, month, or other date range, this value is the first date in that date range.
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets the product ID of the app for which you are retrieving ratings data.
        /// </summary>
        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets the display name of the app.
        /// </summary>
        [JsonProperty("applicationName")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Gets the ISO 3166 country code of the market where the rating was submitted.
        /// </summary>
        [JsonProperty("market")]
        public string Market { get; set; }

        /// <summary>
        /// Gets the OS version on which the rating was submitted.
        /// </summary>
        [JsonProperty("osVersion")]
        public string OsVersion { get; set; }

        /// <summary>
        /// Gets the type of device on which the rating was submitted.
        /// </summary>
        [JsonProperty("deviceType")]
        public DeviceType DeviceType { get; set; }

        /// <summary>
        /// Gets the value that indicates that the review was revised.
        /// </summary>
        [JsonProperty("isRevised")]
        public bool IsRevised { get; set; }

        /// <summary>
        /// Gets the version of the app package that was reviewed.
        /// </summary>
        [JsonProperty("packageVersion")]
        public string PackageVersion { get; set; }

        /// <summary>
        /// Gets the type of device on which the app was reviewed.
        /// </summary>
        [JsonProperty("deviceModel")]
        public string DeviceModel { get; set; }

        /// <summary>
        /// Gets the device family name.
        /// </summary>
        [JsonProperty("productFamily")]
        public ProductFamily ProductFamily { get; set; }

        /// <summary>
        /// Gets the physical RAM, in MB.
        /// </summary>
        [JsonProperty("deviceRAM")]
        public int DeviceRAM { get; set; }

        /// <summary>
        /// Gets the device screen resolution in the format "width x height".
        /// </summary>
        [JsonProperty("deviceScreenResolution")]
        public string DeviceScreenResolution { get; set; }

        /// <summary>
        /// Gets the capacity of the primary storage disk, in GB.
        /// </summary>
        [JsonProperty("deviceStorageCapacity")]
        public int DeviceStorageCapacity { get; set; }

        /// <summary>
        /// Gets the value that indicates that touch is enabled.
        /// </summary>
        [JsonProperty("isTouchEnabled")]
        public bool IsTouchEnabled { get; set; }

        /// <summary>
        /// Gets the reviewer name.
        /// </summary>
        [JsonProperty("reviewerName")]
        public string ReviewerName { get; set; }

        /// <summary>
        /// Gets the app rating, in stars.
        /// </summary>
        [JsonProperty("rating")]
        public int Rating { get; set; }

        /// <summary>
        /// Gets the title of the review.
        /// </summary>
        [JsonProperty("reviewTitle")]
        public string ReviewTitle { get; set; }

        /// <summary>
        /// Gets the text contents of the review.
        /// </summary>
        [JsonProperty("reviewText")]
        public string ReviewText { get; set; }

        /// <summary>
        /// Gets the number of times the review was marked helpful.
        /// </summary>
        [JsonProperty("helpfulCount")]
        public int HelpfulCount { get; set; }

        /// <summary>
        /// Gets the number of times the review was marked not helpful.
        /// </summary>
        [JsonProperty("notHelpfulCount")]
        public int NotHelpfulCount { get; set; }

        /// <summary>
        /// Gets the date a response was submitted.
        /// </summary>
        [JsonProperty("responseDate")]
        public DateTime? ResponseDate { get; set; }

        /// <summary>
        /// Gets the text contents of the response.
        /// </summary>
        [JsonProperty("responseText")]
        public string ResponseText { get; set; }
    }
}
