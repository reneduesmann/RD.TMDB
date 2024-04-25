using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Requests;

public class DiscoverTvShowRequest
{
    public DateOnly? AirDateGte { get; set; } = null;

    public DateOnly? AirDateLte { get; set; } = null;

    public int? FirstAirDateYear { get; set; } = null;

    public DateOnly? FirstAirDateGte { get; set; } = null;

    public DateOnly? FirstAirDateLte { get; set; } = null;

    public bool? IncludeAdult { get; set; } = null;

    public bool? IncludeNullFirstAirDates { get; set; } = null;

    public Iso639_1? Language { get; set; } = null;

    public int? Page { get; set; } = null;

    public bool? ScreenedTheatrically { get; set; } = null;

    public DiscoverTvShowSort? SortBy { get; set; } = null;

    public string? Timezone { get; set; } = null;

    public double? VoteAverageGte { get; set; } = null;

    public double? VoteAverageLte { get; set; } = null;

    public double? VoteCountGte { get; set; } = null;

    public double? VoteCountLte { get; set; } = null;

    /// <summary>
    /// Use in conjunction with <see cref="WithWatchMonetizationTypes"/> or <see cref="WithWatchProvíders"/>.
    /// </summary>
    public string? WatchRegion { get; set; } = null;

    /// <summary>
    /// Can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    public string? WithCompanies { get; set; } = null;

    /// <summary>
    /// Can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    public string? WithGenres { get; set; } = null;

    /// <summary>
    /// Can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    public string? WithKeywords { get; set; } = null;

    public int? WithNetworks { get; set; } = null;

    public Iso3166_1? WithOriginCountry { get; set; } = null;

    public Iso639_1? WithOriginalLanguage { get; set; } = null;

    public int? WithRuntimeGte { get; set; } = null;

    public int? WithRuntimeLte { get; set; } = null;

    /// <summary>
    /// Possible values are: [0, 1, 2, 3, 4, 5], can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    public string? WithStatus { get; set; } = null;

    /// <summary>
    /// Possible values are: [flatrate, free, ads, rent, buy] use in conjunction 
    /// with <see cref="WatchRegion"/>, can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    public string? WithWatchMonetizationTypes { get; set; } = null;

    /// <summary>
    /// Use in conjunction with <see cref="WatchRegion"/>, can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    public string? WithWatchProvíders { get; set; } = null;

    public string? WithoutCompanies { get; set; } = null;

    public string? WithoutGenres { get; set; } = null;

    public string? WithoutKeywords { get; set; } = null;

    public string? WithoutWatchProviders { get; set; } = null;

    /// <summary>
    /// Possible values are: [0, 1, 2, 3, 4, 5, 6], can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    public string? WithType { get; set; } = null;
}
