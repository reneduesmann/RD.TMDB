using RD.TMDB.Domain.Models.TvEpisodes;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace RD.TMDB.Core.JsonConverters;

public sealed class TvEpisodeAccountStateConverter : JsonConverter<TvEpisodeAccountState>
{
    private static JsonSerializerOptions? _newOptions;

    public override TvEpisodeAccountState? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        JsonObject? @object = JsonNode.Parse(ref reader)?.AsObject();

        if (@object is null)
        {
            return default;
        }

        string ratedPropertyName = "rated";

        if (@object.TryGetPropertyValue(ratedPropertyName, out JsonNode? ratedNode) &&
            ratedNode!.GetValueKind() == JsonValueKind.Object)
        {
            @object.Remove(ratedPropertyName);
        }

        if(_newOptions is null)
        {
            _newOptions = new(options);
            _newOptions.Converters.Remove(this);
        }

        TvEpisodeAccountState? accountState = JsonSerializer.Deserialize<TvEpisodeAccountState>(@object.ToJsonString(), _newOptions);

        if (accountState is null)
        {
            return default;
        }

        if (ratedNode is null || ratedNode!.GetValueKind() != JsonValueKind.Object)
        {
            return accountState;
        }

        if (ratedNode is JsonObject ratedObject)
        {
            if (ratedObject.TryGetPropertyValue("value", out JsonNode? valueNode))
            {
                double value = valueNode!.GetValue<double>();
                accountState.RatedValue = value;
                accountState.Rated = true;
            }
        }

        return accountState;
    }

    public override void Write(Utf8JsonWriter writer, TvEpisodeAccountState value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
