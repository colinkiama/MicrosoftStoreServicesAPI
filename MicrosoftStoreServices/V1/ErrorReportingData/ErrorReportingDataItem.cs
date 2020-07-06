using Newtonsoft.Json;
using System;
using WindowsStoreServices.V1.Common.Enums;

namespace WindowsStoreServices.V1.ErrorReportingData
{
    /// <summary>
    /// Error reporting data
    /// </summary>
    public class ErrorReportingDataItem
    {
        /// <summary>
        /// Gets the first date in the date range for the acquisition data.
        /// If the request specified a single day, this value is that date.
        /// If the request specified a week, month, or other date range, this value is the first date in that date range.
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets the product ID of the app for which you want to retrieve IAP acquisition data.
        /// </summary>
        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets the display name of the app.
        /// </summary>
        [JsonProperty("applicationName")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Gets the name of the error.
        /// </summary>
        [JsonProperty("failureName")]
        public string FailureName { get; set; }

        /// <summary>
        /// Gets the unique identifier for the error.
        /// </summary>
        [JsonProperty("failureHash")]
        public string FailureHash { get; set; }

        /// <summary>
        /// Gets the symbol assigned to this error.
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets the OS version on which the error occurred.
        /// </summary>
        [JsonProperty("osVersion")]
        public OsVersion OsVersion { get; set; }

        /// <summary>
        /// Gets the type of error event.
        /// </summary>
        [JsonProperty("eventType")]
        public ErrorEventType EventType { get; set; }

        /// <summary>
        /// Gets the ISO 3166 country code of the device market.
        /// </summary>
        [JsonProperty("market")]
        public string Market { get; set; }

        /// <summary>
        /// Gets the type of device that completed the acquisition.
        /// </summary>
        [JsonProperty("deviceType")]
        public string DeviceType { get; set; }

        /// <summary>
        /// Gets the unique name of the app package that is associated with this error.
        /// </summary>
        [JsonProperty("packageName")]
        public string PackageName { get; set; }

        /// <summary>
        /// Gets the version of the app package that is associated with this error.
        /// </summary>
        [JsonProperty("packageVersion")]
        public string PackageVersion { get; set; }

        /// <summary>
        /// Gets the number of events that are attributed to this error for the specified aggregation level.
        /// </summary>
        [JsonProperty("deviceCount")]
        public int DeviceCount { get; set; }

        /// <summary>
        /// Gets the number of unique devices that correspond to this error for the specified aggregation level.
        /// </summary>
        [JsonProperty("eventCount")]
        public int EventCount { get; set; }
    }
}
