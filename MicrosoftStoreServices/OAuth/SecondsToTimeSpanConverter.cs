using System;
using Newtonsoft.Json;

namespace WindowsStoreServices.OAuth
{
    internal class SecondsToTimeSpanConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TimeSpan);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = reader.Value.ToString();
            long seconds;
            if (long.TryParse(value, out seconds))
            {
                return TimeSpan.FromSeconds(seconds);
            }

            return TimeSpan.Zero;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
