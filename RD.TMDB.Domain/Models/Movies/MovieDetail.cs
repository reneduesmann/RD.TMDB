using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.Collections;
using RD.TMDB.Domain.Models.Companies;
using RD.TMDB.Domain.Models.Genres;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Domain.Models.Movies;

public class MovieDetail : MovieDetailAppendToResponseData
{
    [JsonPropertyName("adult")]
    public bool Adult { get; set; }
    
    [JsonPropertyName("backdrop_path")]
    public string? BackdropPath { get; set; }
    
    [JsonPropertyName("belongs_to_collection")]
    public Collection? BelongsToCollection { get; set; }
    
    [JsonPropertyName("budget")]
    public int Budget { get; set; }

    [JsonPropertyName("genres")]
    public IReadOnlyList<Genre> Genres { get; set; } = [];
    
    [JsonPropertyName("homepage")]
    public Uri? Homepage { get; set; }
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("imdb_id")]
    public string? ImdbId { get; set; }
    
    [JsonPropertyName("original_language")]
    public Iso639_1 OriginalLanguage { get; set; }
    
    [JsonPropertyName("original_title")]
    public string? OriginalTitle { get; set; }
    
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
    
    [JsonPropertyName("release_date")]
    public DateOnly? ReleaseDate { get; set; }
    
    [JsonPropertyName("revenue")]
    public int Revenue { get; set; }
    
    [JsonPropertyName("runtime")]
    public int Runtime { get; set; }

    [JsonPropertyName("origin_country")]
    public IReadOnlyList<Iso3166_1> Countries { get; set; } = [];

    [JsonPropertyName("spoken_languages")]
    public IReadOnlyList<Language> SpokenLanguages { get; set; } = [];
    
    [JsonPropertyName("status")]
    public string? Status { get; set; }
    
    [JsonPropertyName("tagline")]
    public string? Tagline { get; set; }
    
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    
    [JsonPropertyName("video")]
    public bool Video { get; set; }
    
    [JsonPropertyName("vote_average")]
    public double VoteAverage { get; set; }
    
    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }
}