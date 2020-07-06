using Newtonsoft.Json;
using System;
using WindowsStoreServices.V1.Common.Enums;

namespace WindowsStoreServices.V1.AppAcquisitions
{
    /// <summary>
    /// Acquisition data for an application
    /// </summary>
    public class AppAcquisition
    {
        /// <summary>
        /// Gets the product ID of the app for which you are retrieving acquisition data.
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets the first date in the date range for the acquisition data.
        /// If the request specified a single day, this value is that date.
        /// If the request specified a week, month, or other date range, this value is the first date in that date range.
        /// </summary>
        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets the display name of the app.
        /// </summary>
        [JsonProperty("applicationName")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Gets the type of device that completed the acquisition.
        /// </summary>
        [JsonProperty("deviceType")]
        public DeviceType DeviceType { get; set; }

        /// <summary>
        /// Gets the name of the order.
        /// </summary>
        [JsonProperty("orderName")]
        public string OrderName { get; set; }

        /// <summary>
        /// Gets the version of the Store where the acquisition occurred.
        /// </summary>
        [JsonProperty("storeClient")]
        public StoreClientType StoreClient { get; set; }

        /// <summary>
        /// Gets the OS version on which the acquisition occurred.
        /// </summary>
        [JsonProperty("osVersion")]
        public OsVersion OsVersion { get; set; }

        /// <summary>
        /// Gets the ISO 3166 country code of the market where the acquisition occurred.
        /// </summary>
        [JsonProperty("market")]
        public string Market { get; set; }

        /// <summary>
        /// Gets the gender of the user who made the acquisition.
        /// </summary>
        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        /// <summary>
        /// Gets the age group of the user who made the acquisition.
        /// </summary>
        [JsonProperty("ageGroup")]
        public AgeGroup AgeGroup { get; set; }

        /// <summary>
        /// Get the type of acquisition (free, paid, and so on).
        /// </summary>
        [JsonProperty("acquisitionType")]
        public AcquisitionType AcquisitionType { get; set; }

        /// <summary>
        /// Gets the number of acquisitions that occurred during the specified aggregation level.
        /// </summary>
        [JsonProperty("acquisitionQuantity")]
        public int AcquisitionQuantity { get; set; }
    }
}
