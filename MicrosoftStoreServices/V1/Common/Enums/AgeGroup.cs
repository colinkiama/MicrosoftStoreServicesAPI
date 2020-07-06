using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace WindowsStoreServices.V1.Common.Enums
{
    /// <summary>
    /// Age group
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AgeGroup
    {
        /// <summary>
        /// The user is less than 13 years old
        /// </summary>
        [EnumMember(Value = "less than 13")]
        LessThan13,

        /// <summary>
        /// The user is between 13 and 17 years old
        /// </summary>
        [EnumMember(Value = "13-17")]
        Between13And17,

        /// <summary>
        /// The user is between 18 and 24 years old
        /// </summary>
        [EnumMember(Value = "18-24")]
        Between18And24,

        /// <summary>
        /// The user is between 25 and 34 years old
        /// </summary>
        [EnumMember(Value = "25-34")]
        Between25And34,

        /// <summary>
        /// The user is between 35 and 44 years old
        /// </summary>
        [EnumMember(Value = "35-44")]
        Between35And44,

        /// <summary>
        /// The user is between 44 and 55 years old
        /// </summary>
        [EnumMember(Value = "44-55")]
        Between44And55,

        /// <summary>
        /// The user is older than 55 years old
        /// </summary>
        [EnumMember(Value = "greater than 55")]
        GreaterThan55,

        /// <summary>
        /// The age of the user is unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
}
