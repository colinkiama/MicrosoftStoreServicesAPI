using System.Runtime.Serialization;

namespace WindowsStoreServices.V1.Ratings
{
    /// <summary>
    /// Fields eligible for OrderBy on ratings
    /// </summary>
    public enum RatingsOrderBy
    {
        /// <summary>
        /// Order by date
        /// </summary>
        [EnumMember(Value = "date")]
        Date,

        /// <summary>
        /// Order by OS version
        /// </summary>
        [EnumMember(Value = "osVersion")]
        OsVersion,

        /// <summary>
        /// Order by market
        /// </summary>
        [EnumMember(Value = "market")]
        Market,

        /// <summary>
        /// Order by device type
        /// </summary>
        [EnumMember(Value = "deviceType")]
        DeviceType,

        /// <summary>
        /// Order by IsRevised
        /// </summary>
        [EnumMember(Value = "isRevised")]
        IsRevised
    }
}
