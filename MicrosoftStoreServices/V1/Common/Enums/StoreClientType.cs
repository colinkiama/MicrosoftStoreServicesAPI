using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace MicrosoftStoreServicesAPI.V1.Common.Enums
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
        [EnumMember(Value = "Microsoft Store (client)")]
        MicrosoftStoreClient,

        /// <summary>
        /// Windows Store app
        /// </summary>
        [EnumMember(Value = "Windows Store (client)")]
        WindowsStoreClient = MicrosoftStoreClient,


        /// <summary>
        /// Windows Store website
        /// </summary>
        [EnumMember(Value = "Microsoft Store (web)")]
        MicrosoftStoreWeb,

        /// <summary>
        /// Windows Store website
        /// </summary>
        [EnumMember(Value = "Windows Store (web)")]
        WindowsStoreWeb = MicrosoftStoreWeb,

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
