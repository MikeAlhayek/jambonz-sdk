using System.Text.Json;

namespace Jambonz.Client.Core.Json;

public sealed class JambonzJsonSerializerOptions
{
    public JsonSerializerOptions JsonSerializerOptions { get; }

    public JambonzJsonSerializerOptions()
    {
        JsonSerializerOptions = new JsonSerializerOptions();
    }
}
