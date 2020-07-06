using System.Runtime.Serialization;

namespace WindowsStoreServices.V1.AppAcquisitions
{
    /// <summary>
    /// Possible fields to order the result data values for each acquisition. 
    /// </summary>
    public enum AppAcquisitionsOrderBy
    {
        /// <summary>
        /// Date
        /// </summary>
        [EnumMember(Value = "date")]
        Date,

        /// <summary>
        /// Type of acquisition
        /// </summary>
        [EnumMember(Value = "acquisitionType")]
        AcquisitionType,

        /// <summary>
        /// Age group
        /// </summary>
        [EnumMember(Value = "ageGroup")]
        AgeGroup,

        /// <summary>
        /// Place where the app has been acquired
        /// </summary>
        [EnumMember(Value = "storeClient")]
        StoreClient,

        /// <summary>
        /// Gender of the user
        /// </summary>
        [EnumMember(Value = "gender")]
        Gender,

        /// <summary>
        /// Market where the app has been acquired
        /// </summary>
        [EnumMember(Value = "market")]
        Market,

        /// <summary>
        /// OS Version of the user
        /// </summary>
        [EnumMember(Value = "osVersion")]
        OsVersion,

        /// <summary>
        /// Device type
        /// </summary>
        [EnumMember(Value = "deviceType")]
        DeviceType,

        /// <summary>
        /// Order name
        /// </summary>
        [EnumMember(Value = "orderName")]
        OrderName
    }
}
