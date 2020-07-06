using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace MicrosoftStoreServicesAPI.V1.Common.Enums
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
        [EnumMember(Value = "Free")]
        Free,

        /// <summary>
        /// The app is in trial mode
        /// </summary>
        [EnumMember(Value = "Trial")]
        Trial,

        /// <summary>
        /// The app has been bought
        /// </summary>
        [EnumMember(Value = "Paid")]
        Paid,

        /// <summary>
        /// The app has been bought with a promotional code
        /// </summary>
        [EnumMember(Value = "Promotional Code")] /* The API returns a trailing space */
        PromotionalCode,

        /// <summary>
        /// The iap has been bought
        /// </summary>
        [EnumMember(Value = "Iap")]
        Iap,

        /// <summary>
        /// The iap has been bought
        /// </summary>
        [EnumMember(Value = "Subscription Iap")]
        SubscriptionIap,

        /// <summary>
        /// The iap has been bought
        /// </summary>
        [EnumMember(Value = "Private Audience")]
        PrivateAudience,

        /// <summary>
        /// The iap has been bought
        /// </summary>
        [EnumMember(Value = "Pre Order")]
        PreOrder,
        GamePass,

        /// <summary>
        /// The iap has been bought
        /// </summary>
        [EnumMember(Value = "Xbox Game Pass")]
        XboxGamePass = GamePass,

        /// <summary>
        /// The iap has been bought
        /// </summary>
        [EnumMember(Value = "Game Pass")]
        LegacyGamePass = GamePass,

        /// <summary>
        /// The iap has been bought
        /// </summary>
        [EnumMember(Value = "Disk")]
        Disk,

        /// <summary>
        /// The iap has been bought
        /// </summary>
        [EnumMember(Value = "Prepaid Code")]
        PrepaidCode,

        /// <summary>
        /// The iap has been bought
        /// </summary>
        [EnumMember(Value = "Charged Pre Order")]
        ChargedPreOrder,

        /// <summary>
        /// The iap has been bought
        /// </summary>
        [EnumMember(Value = "Cancelled Pre Order")]
        CancelledPreOrder,

        /// <summary>
        /// The iap has been bought
        /// </summary>
        [EnumMember(Value = "Failed Code")]
        FailedPreOrder,
    }
}
