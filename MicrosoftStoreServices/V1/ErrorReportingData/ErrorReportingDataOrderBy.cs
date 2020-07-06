using Newtonsoft.Json;

namespace WindowsStoreServices.V1.ErrorReportingData
{
    /// <summary>
    /// Fields eligible for OrderBy parameter in ErrorReportingData
    /// </summary>
    public enum ErrorReportingDataOrderBy
    {
        /// <summary>
        /// Order by date
        /// </summary>
        [JsonProperty("date")]
        Date,

        /// <summary>
        /// Order by failure name
        /// </summary>
        [JsonProperty("failureName")]
        FailureName,

        /// <summary>
        /// Order by failure hash
        /// </summary>
        [JsonProperty("failureHash")]
        FailureHash,

        /// <summary>
        /// Order by symbol
        /// </summary>
        [JsonProperty("symbol")]
        Symbol,

        /// <summary>
        /// Order by OS version
        /// </summary>
        [JsonProperty("osVersion")]
        OsVersion,

        /// <summary>
        /// Order by event type
        /// </summary>
        [JsonProperty("eventType")]
        EventType,

        /// <summary>
        /// Order by market
        /// </summary>
        [JsonProperty("market")]
        Market,

        /// <summary>
        /// Order by device type
        /// </summary>
        [JsonProperty("deviceType")]
        DeviceType,

        /// <summary>
        /// Order by package name
        /// </summary>
        [JsonProperty("packageName")]
        PackageName,

        /// <summary>
        /// Order by package version
        /// </summary>
        [JsonProperty("packageVersion")]
        PackageVersion
    }
}
