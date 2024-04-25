using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.Companies;
using RD.TMDB.Domain.Models.Networks;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Domain.Models.TvShows;

public class TvShowDetail : TvShowDetailAppendToResponseData
{
    [JsonPropertyName("adult")]
    public bool Adult { get; set; }
    
    [JsonPropertyName("backdrop_path")]
    public string? BackdropPath { get; set; }

    [JsonPropertyName("created_by")]
    public IReadOnlyList<CreatedBy> CreatedBy { get; set; } = [];

    [JsonPropertyName("episode_run_time")]
    public IReadOnlyList<int> EpisodeRunTime { get; set; } = [];
    
    [JsonPropertyName("first_air_date")]
    public DateOnly FirstAirDate { get; set; }

    [JsonPropertyName("genres")]
    public IReadOnlyList<TvShowGenre> Genres { get; set; } = [];
    
    [JsonPropertyName("homepage")]
    public Uri? Homepage { get; set; }
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("in_production")]
    public bool InProduction { get; set; }

    [JsonPropertyName("languages")]
    public IReadOnlyList<Iso639_1> Languages { get; set; } = [];
    
    [JsonPropertyName("last_air_date")]
    public DateOnly LastAirDate { get; set; }
    
    [JsonPropertyName("last_episode_to_air")]
    public TvEpisode? LastEpisodeToAir { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("next_episode_to_air")]
    public TvEpisode? NextEpisodeToAir { get; set; }

    [JsonPropertyName("networks")]
    public IReadOnlyList<Network> Networks { get; set; } = [];
    
    [JsonPropertyName("number_of_episodes")]
    public int NumberOfEpisodes { get; set; }
    
    [JsonPropertyName("number_of_seasons")]
    public int NumberOfSeasons { get; set; }

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

    [JsonPropertyName("production_companies")]
    public IReadOnlyList<Company> ProductionCompanies { get; set; } = [];

    [JsonPropertyName("production_countries")]
    public IReadOnlyList<Country> ProductionCountries { get; set; } = [];

    [JsonPropertyName("seasons")]
    public IReadOnlyList<TvSeason> Seasons { get; set; } = [];
    
    [JsonPropertyName("spoken_languages")]
    public IReadOnlyList<Language> SpokenLanguages { get; set; } = [];
    
    [JsonPropertyName("status")]
    public string? Status { get; set; }
    
    [JsonPropertyName("tagline")]
    public string? Tagline { get; set; }
    
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    
    [JsonPropertyName("vote_average")]
    public double VoteAverage { get; set; }
    
    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }
}