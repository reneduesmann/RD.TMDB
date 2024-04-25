using RD.TMDB.Domain.Models.Genres;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using static RD.TMDB.Domain.Configurations.ErrorMessage;

namespace RD.TMDB.Core.JsonConverters;

public sealed class GenreListConverter<TGenre> : JsonConverter<IReadOnlyList<TGenre>>
    where TGenre : struct, Enum
{
    public override IReadOnlyList<TGenre>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        List<TGenre> result = [];
        JsonNode? node = JsonNode.Parse(ref reader);

        if (node is null)
        {
            throw new JsonException(FailedToParseReaderToNode);
        }

        foreach (JsonNode? jsonNode in node.AsArray())
        {
            if (jsonNode is null)
            {
                continue;
            }

            if (jsonNode is JsonObject jsonObject)
            {
                Genre? genre = jsonNode.Deserialize<Genre>(options);

                if (genre is null)
                {
                    throw new JsonException(string.Format(FailedToDeserializeType, "genre"));
                }

                result.Add((TGenre)Enum.Parse(typeof(TGenre), genre.Id.ToString()));

                continue;
            }

            result.Add((TGenre)Enum.Parse(typeof(TGenre), jsonNode.GetValue<int>().ToString()));
        }

        return result;
    }

    public override void Write(Utf8JsonWriter writer, IReadOnlyList<TGenre> value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
