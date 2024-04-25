using RD.TMDB.Domain.Models.TvEpisodes;

namespace RD.TMDB.Domain.Models.TvSeasons;

public class TvSeasonDetail : TvSeasonDetailAppendToResponseData
{
    [JsonPropertyName("_id")]
    public string? InternalId { get; set; }
    
    [JsonPropertyName("air_date")]
    public DateOnly AirDate { get; set; }

    [JsonPropertyName("episodes")]
    public IReadOnlyList<TvEpisodeDetail> Episodes { get; set; } = [];
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("overview")]
    public string? Overview { get; set; }
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("poster_path")]
    public string? PosterPath { get; set; }
    
    [JsonPropertyName("season_number")]
    public int SeasonNumber { get; set; }
    
    [JsonPropertyName("vote_average")]
    public double VoteAverage { get; set; }
}