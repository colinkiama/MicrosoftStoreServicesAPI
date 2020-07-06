using Newtonsoft.Json;
using System;

namespace WindowsStoreServices.OAuth
{
    internal class SecondsToDateTimeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = reader.Value.ToString();
            long seconds;
            if (long.TryParse(value, out seconds))
            {
                return new DateTime(1970, 1, 1).AddSeconds(seconds);
            }

            return DateTime.MinValue;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
