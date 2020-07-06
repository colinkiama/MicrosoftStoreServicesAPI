using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace WindowsStoreServices.V1.Common.Enums
{
    /// <summary>
    /// Type of acquisition of the app/IAP
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AcquisitionType
    {
        /// <summary>
        /// The app is free
        /// </summary>
        [EnumMember(Value = "free")]
        Free,

        /// <summary>
        /// The app is in trial mode
        /// </summary>
        [EnumMember(Value = "trial")]
        Trial,

        /// <summary>
        /// The app has been bought
        /// </summary>
        [EnumMember(Value = "paid")]
        Paid,

        /// <summary>
        /// The app has been bought with a promotional code
        /// </summary>
        [EnumMember(Value = "promotional code ")] /* The API returns a trailing space */
        PromotionalCode,

        /// <summary>
        /// The iap has been bought
        /// </summary>
        [EnumMember(Value = "iap")]
        Iap
    }
}
