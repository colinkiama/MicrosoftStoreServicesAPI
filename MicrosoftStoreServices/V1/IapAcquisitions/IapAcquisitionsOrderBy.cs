using System.Runtime.Serialization;

namespace WindowsStoreServices.V1.IapAcquisitions
{
    /// <summary>
    /// Fields eligible for OrderBy parameters on IAP acquisitions
    /// </summary>
    public enum IapAcquisitionsOrderBy
    {
        /// <summary>
        /// Order by date
        /// </summary>
        [EnumMember(Value = "date")]
        Date,

        /// <summary>
        /// Order by acquisition type
        /// </summary>
        [EnumMember(Value = "acquisitionType")]
        AcquisitionType,

        /// <summary>
        /// Order by age group
        /// </summary>
        [EnumMember(Value = "ageGroup")]
        AgeGroup,

        /// <summary>
        /// Order by store client type
        /// </summary>
        [EnumMember(Value = "storeClient")]
        StoreClient,

        /// <summary>
        /// Order by gender
        /// </summary>
        [EnumMember(Value = "gender")]
        Gender,

        /// <summary>
        /// Order by market
        /// </summary>
        [EnumMember(Value = "market")]
        Market,

        /// <summary>
        /// Order by OS version
        /// </summary>
        [EnumMember(Value = "osVersion")]
        OsVersion,

        /// <summary>
        /// Order by device type
        /// </summary>
        [EnumMember(Value = "deviceType")]
        DeviceType,

        /// <summary>
        /// Order by order name
        /// </summary>
        [EnumMember(Value = "orderName")]
        OrderName
    }
}
