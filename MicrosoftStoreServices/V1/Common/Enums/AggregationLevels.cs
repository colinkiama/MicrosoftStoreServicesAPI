using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace WindowsStoreServices.V1.Common.Enums
{
    /// <summary>
    /// Aggregation levels
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AggregationLevels
    {
        /// <summary>
        /// Aggregate per day
        /// </summary>
        [EnumMember(Value = "day")]
        Day,

        /// <summary>
        /// Aggregate per week
        /// </summary>
        [EnumMember(Value = "week")]
        Week,

        /// <summary>
        /// Aggregate per month
        /// </summary>
        [EnumMember(Value = "month")]
        Month
    }
}
