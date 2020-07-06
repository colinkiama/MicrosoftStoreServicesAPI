using System.Runtime.Serialization;

namespace WindowsStoreServices.V1.ErrorReportingData
{
    /// <summary>
    /// Fields eligible for GroupBy parameter in ErrorReportingData
    /// </summary>
    public enum ErrorReportingDataGroupBy
    {
        /// <summary>
        /// Group by date
        /// </summary>
        [EnumMember(Value = "date")]
        Date,

        /// <summary>
        /// Group by Application identifier
        /// </summary>
        [EnumMember(Value = "applicationId")]
        ApplicationId,

        /// <summary>
        /// Group by application name
        /// </summary>
        [EnumMember(Value = "applicationName")]
        ApplicationName,

        /// <summary>
        /// Group by device count
        /// </summary>
        [EnumMember(Value = "deviceCount")]
        DeviceCount,

        /// <summary>
        /// Group by event count
        /// </summary>
        [EnumMember(Value = "eventCount")]
        EventCount
    }
}
