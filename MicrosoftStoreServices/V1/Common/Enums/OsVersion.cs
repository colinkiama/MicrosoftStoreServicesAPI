using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace WindowsStoreServices.V1.Common.Enums
{
    /// <summary>
    /// Version of the OS used by the user
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OsVersion
    {
        /// <summary>
        /// Windows Phone 7.5
        /// </summary>
        [EnumMember(Value = "Windows Phone 7.5")]
        WindowsPhone75,

        /// <summary>
        /// Windows Phone 8
        /// </summary>
        [EnumMember(Value = "Windows Phone 8")]
        WindowsPhone8,

        /// <summary>
        /// Windows Phone 8.1
        /// </summary>
        [EnumMember(Value = "Windows Phone 8.1")]
        WindowsPhone81,

        /// <summary>
        /// Windows Phone 10
        /// </summary>
        [EnumMember(Value = "Windows Phone 10")]
        WindowsPhone10,

        /// <summary>
        /// Windows 8
        /// </summary>
        [EnumMember(Value = "Windows 8")]
        Windows8,

        /// <summary>
        /// Windows 8.1
        /// </summary>
        [EnumMember(Value = "Windows 8.1")]
        Windows81,

        /// <summary>
        /// Windows 10
        /// </summary>
        [EnumMember(Value = "Windows 10")]
        Windows10,

        /// <summary>
        /// Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
}
