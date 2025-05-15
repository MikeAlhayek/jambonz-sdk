using System.Text.Json;
using System.Text.Json.Serialization;

namespace Jambonz.Client.Core.Json;

public sealed class JsonStringEnumMemberConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        return typeToConvert.IsEnum;
    }

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var converterType = typeof(JsonStringEnumMemberConverter<>).MakeGenericType(typeToConvert);
        return (JsonConverter)Activator.CreateInstance(converterType)!;
    }
}
