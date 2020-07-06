using Newtonsoft.Json;

namespace WindowsStoreServices.V1.Common
{
    public class Response<T>
    {
        [JsonProperty("Value")]
        public T[] Values { get; set; }
        [JsonProperty("@nextLink")]
        public string NextLink { get; set; }
        [JsonProperty("TotalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("data")]
        public object[] Data { get; set; }
        [JsonProperty("details")]
        public object[] Details { get; set; }
        [JsonProperty("innererror")]
        public Response<T> InnerError { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("source")]
        public string Source { get; set; }
    }
}
