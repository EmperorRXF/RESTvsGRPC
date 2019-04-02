using Google.Protobuf;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace ModelLibrary.Data
{
    public class ProtobufJsonConvertor : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(IMessage).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var converter = new ExpandoObjectConverter();
            var o = converter.ReadJson(reader, objectType, existingValue, serializer);
            
            var text = JsonConvert.SerializeObject(o);

            var message = (IMessage) Activator.CreateInstance(objectType);

            var parser = new JsonParser(JsonParser.Settings.Default.WithIgnoreUnknownFields(true));
            return parser.Parse(text, message.Descriptor);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue(JsonFormatter.Default.Format((IMessage)value));
        }
    }
}
