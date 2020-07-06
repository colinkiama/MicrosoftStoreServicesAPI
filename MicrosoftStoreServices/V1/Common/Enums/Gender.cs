using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace WindowsStoreServices.V1.Common.Enums
{
    /// <summary>
    /// Gender of the user
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Gender
    {
        /// <summary>
        /// Nale
        /// </summary>
        [EnumMember(Value = "m")]
        Male,

        /// <summary>
        /// Female
        /// </summary>
        [EnumMember(Value = "f")]
        Female,

        /// <summary>
        /// Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
}
