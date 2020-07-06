using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace WindowsStoreServices.V1.ErrorReportingData
{
    /// <summary>
    /// Type of the error event
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ErrorEventType
    {
        /// <summary>
        /// The app has crashed
        /// </summary>
        [EnumMember(Value = "crash")]
        Crash,

        /// <summary>
        /// The app has hanged
        /// </summary>
        [EnumMember(Value = "hang")]
        Hang,

        /// <summary>
        /// The app has reached memory limit
        /// </summary>
        [EnumMember(Value = "memory")]
        Memory,

        /// <summary>
        /// JSE
        /// </summary>
        [EnumMember(Value = "jse")]
        JSE
    }
}
