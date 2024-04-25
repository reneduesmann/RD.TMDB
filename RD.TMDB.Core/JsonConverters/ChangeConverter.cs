using RD.TMDB.Domain.Models.Changes;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace RD.TMDB.Core.JsonConverters;

public sealed class ChangeConverter : JsonConverter<Change>
{
    private static JsonSerializerOptions? _newOptions;

    public override Change? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        JsonObject? @object = JsonNode.Parse(ref reader)?.AsObject();

        if (@object is null)
        {
            return default;
        }

        string keyPropertyName = "key";

        if (!@object.TryGetPropertyValue(keyPropertyName, out JsonNode? keyNode) || keyNode is null)
        {
            throw new JsonException();
        }

        string itemsPropertyName = "items";

        if (!@object.TryGetPropertyValue(itemsPropertyName, out JsonNode? itemsNode) || itemsNode is null)
        {
            throw new JsonException();
        }

        foreach (JsonNode? itemNode in itemsNode.AsArray())
        {
            if (itemNode is null)
            {
                continue;
            }

            itemNode[keyPropertyName] = keyNode.Deserialize<JsonNode>() ?? throw new JsonException();
        }

        if(_newOptions is null)
        {
            _newOptions = new(options);
            _newOptions.Converters.Remove(this);
        }

        return @object.Deserialize<Change>(_newOptions);
    }

    public override void Write(Utf8JsonWriter writer, Change value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
