using System;
using Newtonsoft.Json;
using WindowsStoreServices.V1.Common.Enums;

namespace WindowsStoreServices.V1.Ratings
{
    /// <summary>
    /// Rating data
    /// </summary>
    public class Rating
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
        public string OsVersion { get; set; } /* Despite what's stated on MSDN, this field contains the version number instead of  */

        /// <summary>
        /// Gets the type of device on which the rating was submitted.
        /// </summary>
        [JsonProperty("deviceType")]
        public DeviceType DeviceType { get; set; }

        /// <summary>
        /// Gets the value that indicates that the rating was revised.
        /// </summary>
        [JsonProperty("isRevised")]
        public bool IsRevised { get; set; }

        /// <summary>
        /// Gets the number of one-star ratings.
        /// </summary>
        [JsonProperty("oneStar")]
        public int OneStar { get; set; }

        /// <summary>
        /// Gets the number of two-star ratings.
        /// </summary>
        [JsonProperty("twoStar")]
        public int TwoStars { get; set; }

        /// <summary>
        /// Gets the number of three-star ratings.
        /// </summary>
        [JsonProperty("threeStars")]
        public int ThreeStars { get; set; }

        /// <summary>
        /// Gets the number of four-star ratings.
        /// </summary>
        [JsonProperty("fourStars")]
        public int FourStars { get; set; }

        /// <summary>
        /// Gets the number of five-star ratings.
        /// </summary>
        [JsonProperty("fiveStars")]
        public int FiveStars { get; set; }
    }
}
