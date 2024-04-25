using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Shared;

public class TvShow : IKnownFor
{
    [JsonPropertyName("adult")]
    public bool Adult { get; set; }

    [JsonPropertyName("backdrop_path")]
    public string? BackdropPath { get; set; }

    [JsonPropertyName("genre_ids")]
    public IReadOnlyList<TvShowGenre> GenreIds { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("origin_country")]
    public IReadOnlyList<Iso3166_1> OriginCountry { get; set; } = [];

    [JsonPropertyName("original_language")]
    public Iso639_1 OriginalLanguage { get; set; }

    [JsonPropertyName("original_name")]
    public string? OriginalName { get; set; }

    [JsonPropertyName("overview")]
    public string? Overview { get; set; }

    [JsonPropertyName("popularity")]
    public double Popularity { get; set; }

    [JsonPropertyName("poster_path")]
    public string? PosterPath { get; set; }

    [JsonPropertyName("first_air_date")]
    public DateOnly FirstAirDate { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("vote_average")]
    public double VoteAverage { get; set; }

    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }

    [JsonPropertyName("media_type")]
    public MediaType MediaType { get; set; } = MediaType.TvShow;

    [JsonPropertyName("seasons")]
    public IReadOnlyList<TvSeason> Seasons { get; set; } = [];

    [JsonPropertyName("episodes")]
    public IReadOnlyList<TvEpisode> Episodes { get; set; } = [];
}