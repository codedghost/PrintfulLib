using System;
using Newtonsoft.Json;

namespace PrintfulLib.Converters
{
    public class TimestampDateTimeConverter : JsonConverter<DateTime>
    {
        private static readonly DateTime _epochDateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        public override void WriteJson(JsonWriter writer, DateTime value, JsonSerializer serializer)
        {
            var relativeValue = value - _epochDateTime;

            writer.WriteRawValue(relativeValue.TotalMilliseconds + "000");
        }

        public override DateTime ReadJson(JsonReader reader, Type objectType, DateTime existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            if (reader.Value == null)
            {
                throw new ArgumentException("No value given for DateTime field");
            }

            return _epochDateTime.AddSeconds((long) reader.Value);
        }
    }
}