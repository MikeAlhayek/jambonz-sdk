using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Jambonz.Client.Core.Json;

public sealed class JsonStringEnumMemberConverter<T> : JsonConverter<T>
    where T : struct, Enum
{
    private static readonly ConcurrentDictionary<T, string> _enumToString = new();
    private static readonly ConcurrentDictionary<string, T> _stringToEnum = new(StringComparer.OrdinalIgnoreCase);

    static JsonStringEnumMemberConverter()
    {
        var type = typeof(T);
        foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.Static))
        {
            var enumValue = (T)field.GetValue(null)!;
            var enumMemberAttr = field.GetCustomAttribute<EnumMemberAttribute>();
            var stringValue = enumMemberAttr?.Value ?? field.Name;

            _enumToString[enumValue] = stringValue;
            _stringToEnum[stringValue] = enumValue;
        }
    }

    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var key = reader.GetString();
        if (key != null && _stringToEnum.TryGetValue(key, out var enumValue))
        {
            return enumValue;
        }
        throw new JsonException($"Unable to convert '{key}' to '{typeof(T)}'.");
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        if (_enumToString.TryGetValue(value, out var stringValue))
        {
            writer.WriteStringValue(stringValue);
        }
        else
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
