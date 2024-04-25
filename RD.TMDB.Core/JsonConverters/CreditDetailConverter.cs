using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.Credits;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using static RD.TMDB.Domain.Configurations.ErrorMessage;

namespace RD.TMDB.Core.JsonConverters;

public sealed class CreditDetailConverter : JsonConverter<CreditDetail>
{
    private readonly Dictionary<MediaType, Type> _types = new()
    {
        { MediaType.Movie, typeof(MovieCreditMedia) },
        { MediaType.Tv, typeof(TvCreditMedia) },
        { MediaType.TvShow, typeof(TvCreditMedia) }
    };

    private static JsonSerializerOptions? _newOptions;

    public override CreditDetail? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        JsonObject? @object = JsonNode.Parse(ref reader)?.AsObject();

        if (@object is null)
        {
            return default;
        }

        string mediaPropertyName = "media";
        
        if (!@object.TryGetPropertyValue(mediaPropertyName, out JsonNode? mediaNode) || mediaNode is null)
        {
            throw new JsonException(string.Format(PropertyNotFound, mediaPropertyName));
        }

        @object.Remove(mediaPropertyName);

        if(_newOptions is null)
        {
            _newOptions = new(options);
            _newOptions.Converters.Remove(this);
        }

        CreditDetail? creditDetail = JsonSerializer.Deserialize<CreditDetail>(@object.ToJsonString(), _newOptions);

        if (creditDetail is null)
        {
            return null;
        }

        Type typeToDeserialize = this._types.FirstOrDefault(x =>
            x.Key == creditDetail.MediaType).Value;

        creditDetail.Media = mediaNode.Deserialize(typeToDeserialize, options) as ICreditMedia;

        return creditDetail;
    }

    public override void Write(Utf8JsonWriter writer, CreditDetail value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
