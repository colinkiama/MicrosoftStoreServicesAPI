using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace WindowsStoreServices.V1.Common.Enums
{
    /// <summary>
    /// Device type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeviceType
    {
        /// <summary>
        /// PC
        /// </summary>
        [EnumMember(Value = "PC")]
        PC,

        /// <summary>
        /// Tablet
        /// </summary>
        [EnumMember(Value = "Tablet")]
        Tablet,

        /// <summary>
        /// Phone
        /// </summary>
        [EnumMember(Value = "Phone")]
        Phone,

        /// <summary>
        /// IoT
        /// </summary>
        [EnumMember(Value = "IoT")]
        IoT,

        /// <summary>
        /// Wearable
        /// </summary>
        [EnumMember(Value = "Wearable")]
        Wearable,

        /// <summary>
        /// Server
        /// </summary>
        [EnumMember(Value = "Server")]
        Server,

        /// <summary>
        /// Collaborative
        /// </summary>
        [EnumMember(Value = "Collaborative")]
        Collaborative,

        /// <summary>
        /// Other
        /// </summary>
        [EnumMember(Value = "Other")]
        Other,

        /// <summary>
        /// Unknown
        /// </summary>
        [EnumMember(Value = "")]
        Unknown
    }
}
