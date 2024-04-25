using RD.TMDB.Domain.Models.TvSeasons;
using RD.TMDB.Domain.Models.TvShows;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace RD.TMDB.Core.JsonConverters;

public class TvShowDetailConverter : JsonConverter<TvShowDetail>
{
    private static JsonSerializerOptions? _newOptions;

    public override TvShowDetail? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        JsonNode? node = JsonNode.Parse(ref reader);
        JsonObject? @object = node?.AsObject();

        if (node is null || @object is null)
        {
            return null;
        }

        if(_newOptions is null)
        {
            _newOptions = new JsonSerializerOptions(options);
            _newOptions.Converters.Remove(this);
        }

        Dictionary<string, TvSeasonDetail> tvSeasonEpisodes = [];
        List<KeyValuePair<string, JsonNode?>> seasons = @object
            .Where(x => x.Key.StartsWith("season/"))
            .ToList();

        foreach (KeyValuePair<string, JsonNode?> item in seasons)
        {
            @object.Remove(item.Key);
            TvSeasonDetail? tvSeasonDetail = item.Value.Deserialize<TvSeasonDetail>(_newOptions);

            if(tvSeasonDetail is null)
            {
                continue;
            }

            tvSeasonEpisodes.Add(item.Key, tvSeasonDetail);
        }

        TvShowDetail? tvShowDetail = @object.Deserialize<TvShowDetail>(_newOptions);

        if(tvShowDetail is not null)
        {
            tvShowDetail.TvSeasonEpisodes = tvSeasonEpisodes;
        }

        return tvShowDetail;
    }

    public override void Write(Utf8JsonWriter writer, TvShowDetail value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
