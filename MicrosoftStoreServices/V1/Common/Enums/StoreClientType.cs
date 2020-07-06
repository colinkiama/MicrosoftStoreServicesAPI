using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace WindowsStoreServices.V1.Common.Enums
{
    /// <summary>
    /// Type of the store client
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StoreClientType
    {
        /// <summary>
        /// Windows Phone Store app
        /// </summary>
        [EnumMember(Value = "Windows Phone Store (client)")]
        WindowsPhoneStoreClient,

        /// <summary>
        /// Windows Store app
        /// </summary>
        [EnumMember(Value = "Windows Store (client)")]
        WindowsStoreClient,

        /// <summary>
        /// Windows Store website
        /// </summary>
        [EnumMember(Value = "Windows Store (web)")]
        WindowsStoreWeb,

        /// <summary>
        /// Volume purchase
        /// </summary>
        [EnumMember(Value = "Volume purchase by organizations")]
        VolumePurchase,

        /// <summary>
        /// Other
        /// </summary>
        [EnumMember(Value = "Other")]
        Other
    }
}
