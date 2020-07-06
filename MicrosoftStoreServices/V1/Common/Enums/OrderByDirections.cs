using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace WindowsStoreServices.V1.Common.Enums
{
    /// <summary>
    /// OrderBy directions
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderByDirections
    {
        /// <summary>
        /// Ascending
        /// </summary>
        [EnumMember(Value = "asc")]
        Ascending,

        /// <summary>
        /// Descending
        /// </summary>
        [EnumMember(Value = "desc")]
        Descending
    }
}
