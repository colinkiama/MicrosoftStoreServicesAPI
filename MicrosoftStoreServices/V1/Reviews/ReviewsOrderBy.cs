using System.Runtime.Serialization;

namespace WindowsStoreServices.V1.Reviews
{
    /// <summary>
    /// Fields eligible for OrderBy on reviews
    /// </summary>
    public enum ReviewsOrderBy
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
        IsRevised,

        /// <summary>
        /// Order by package version
        /// </summary>
        [EnumMember(Value = "packageVersion")]
        PackageVersion,

        /// <summary>
        /// Order by device model
        /// </summary>
        [EnumMember(Value = "deviceModel")]
        DeviceModel,

        /// <summary>
        /// Order by product family
        /// </summary>
        [EnumMember(Value = "productFamily")]
        ProductFamily,

        /// <summary>
        /// Order by device screen resolution
        /// </summary>
        [EnumMember(Value = "deviceScreenResolution")]
        DeviceScreenResolution,

        /// <summary>
        /// Order by IsTouchEnabled
        /// </summary>
        [EnumMember(Value = "isTouchEnabled")]
        IsTouchEnabled,

        /// <summary>
        /// Order by reviewer name
        /// </summary>
        [EnumMember(Value = "reviewerName")]
        ReviewerName,

        /// <summary>
        /// Order by review title
        /// </summary>
        [EnumMember(Value = "reviewTitle")]
        ReviewTitle,

        /// <summary>
        /// Order by review text
        /// </summary>
        [EnumMember(Value = "reviewText")]
        ReviewText,

        /// <summary>
        /// Order by helpful count
        /// </summary>
        [EnumMember(Value = "helpfulCount")]
        HelpfulCount,

        /// <summary>
        /// Order by not helpful count
        /// </summary>
        [EnumMember(Value = "notHelpfulCount")]
        NotHelpfulCount,

        /// <summary>
        /// Order by response date
        /// </summary>
        [EnumMember(Value = "responseDate")]
        ResponseDate,

        /// <summary>
        /// Order by response text
        /// </summary>
        [EnumMember(Value = "responseText")]
        ResponseText,

        /// <summary>
        /// Order by device RAM
        /// </summary>
        [EnumMember(Value = "deviceRAM")]
        DeviceRAM,

        /// <summary>
        /// Order by device storage capacity
        /// </summary>
        [EnumMember(Value = "deviceStorageCapacity")]
        DeviceStorageCapacity,

        /// <summary>
        /// Order by rating
        /// </summary>
        [EnumMember(Value = "rating")]
        Rating
    }
}
