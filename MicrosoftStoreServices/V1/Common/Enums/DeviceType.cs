using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace MicrosoftStoreServicesAPI.V1.Common.Enums
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
        /// Phone
        /// </summary>
        [EnumMember(Value = "Phone")]
        Phone,

        /// <summary>
        /// Xbox One
        /// </summary>
        [EnumMember(Value = "Console-Xbox One")]
        XboxOne,

        /// <summary>
        /// Xbox Series X
        /// </summary>
        [EnumMember(Value = "Console-Xbox Series X")]
        XboxSeriesX,

        /// <summary>
        /// IoT
        /// </summary>
        [EnumMember(Value = "IoT")]
        IoT,

        /// <summary>
        /// Server
        /// </summary>
        [EnumMember(Value = "Server")]
        Server,

        /// <summary>
        /// Tablet
        /// </summary>
        [EnumMember(Value = "Tablet")]
        Tablet,

        /// <summary>
        /// Holographic
        /// </summary>
        [EnumMember(Value = "Holographic")]
        Holographic,

        /// <summary>
        /// Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
}
