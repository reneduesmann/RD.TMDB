using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.Shared;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using static RD.TMDB.Domain.Configurations.ErrorMessage;

namespace RD.TMDB.Core.JsonConverters;

public sealed class KnownForConverter : JsonConverter<IKnownFor>
{
    private readonly Dictionary<MediaType, Type> _types = new()
    {
        { MediaType.Person, typeof(Person) },
        { MediaType.Movie, typeof(Movie) },
        { MediaType.Tv, typeof(TvShow) },
        { MediaType.TvShow, typeof(TvShow) }
    };

    public override IKnownFor? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        JsonNode? node = JsonNode.Parse(ref reader);

        if (node is null)
        {
            throw new JsonException(FailedToParseReaderToNode);
        }

        string mediaTypePropertyName = "media_type";

        if (node[mediaTypePropertyName] is null)
        {
            throw new JsonException(string.Format(PropertyNotFound, mediaTypePropertyName));
        }

        string mediaTypeValue = node[mediaTypePropertyName]?.GetValue<string>() ?? string.Empty;

        if (!Enum.TryParse(mediaTypeValue, true, out MediaType mediaType))
        {
            throw new JsonException(string.Format(FailedToConvertType, mediaTypeValue, typeof(MediaType)));
        }

        Type typeToDeserialize = this._types.FirstOrDefault(x =>
            x.Key == mediaType).Value;

        return node.Deserialize(typeToDeserialize, options) as IKnownFor;
    }

    public override void Write(Utf8JsonWriter writer, IKnownFor value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
