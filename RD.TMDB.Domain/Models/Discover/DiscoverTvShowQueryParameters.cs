using Refit;

namespace RD.TMDB.Domain.Models.Discover;

public class DiscoverTvShowQueryParameters
{
    [AliasAs("air_date.gte")]
    public string? AirDateGte { get; set; } = null;

    [AliasAs("air_date.lte")]
    public string? AirDateLte { get; set; } = null;

    [AliasAs("first_air_date_year")]
    public int? FirstAirDateYear { get; set; } = null;

    [AliasAs("first_air_date.gte")]
    public string? FirstAirDateGte { get; set; } = null;

    [AliasAs("first_air_date.lte")]
    public string? FirstAirDateLte { get; set; } = null;

    [AliasAs("include_adult")]
    public bool? IncludeAdult { get; set; } = null;

    [AliasAs("include_null_first_air_dates")]
    public bool? IncludeNullFirstAirDates { get; set; } = null;

    [AliasAs("language")]
    public string? Language { get; set; } = null;

    [AliasAs("page")]
    public int? Page { get; set; } = null;

    [AliasAs("screened_theatrically")]
    public bool? ScreenedTheatrically { get; set; } = null;

    [AliasAs("sort_by")]
    public string? SortBy { get; set; } = null;

    [AliasAs("timezone")]
    public string? Timezone { get; set; } = null;

    [AliasAs("vote_average.gte")]
    public double? VoteAverageGte { get; set; } = null;

    [AliasAs("vote_average.lte")]
    public double? VoteAverageLte { get; set; } = null;

    [AliasAs("vote_count.gte")]
    public double? VoteCountGte { get; set; } = null;

    [AliasAs("vote_count.lte")]
    public double? VoteCountLte { get; set; } = null;

    /// <summary>
    /// Use in conjunction with <see cref="WithWatchMonetizationTypes"/> or <see cref="WithWatchProvíders"/>.
    /// </summary>
    [AliasAs("watch_region")]
    public string? WatchRegion { get; set; } = null;

    /// <summary>
    /// Can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    [AliasAs("with_companies")]
    public string? WithCompanies { get; set; } = null;

    /// <summary>
    /// Can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    [AliasAs("with_genres")]
    public string? WithGenres { get; set; } = null;

    /// <summary>
    /// Can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    [AliasAs("with_keywords")]
    public string? WithKeywords { get; set; } = null;

    [AliasAs("with_networks")]
    public int? WithNetworks { get; set; } = null;

    [AliasAs("with_origin_country")]
    public string? WithOriginCountry { get; set; } = null;

    [AliasAs("with_original_language")]
    public string? WithOriginalLanguage { get; set; } = null;

    [AliasAs("with_runtime.gte")]
    public int? WithRuntimeGte { get; set; } = null;

    [AliasAs("with_runtime.lte")]
    public int? WithRuntimeLte { get; set; } = null;

    /// <summary>
    /// Possible values are: [0, 1, 2, 3, 4, 5], can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    [AliasAs("with_status")]
    public string? WithStatus { get; set; } = null;

    /// <summary>
    /// Possible values are: [flatrate, free, ads, rent, buy] use in conjunction 
    /// with <see cref="WatchRegion"/>, can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    [AliasAs("with_watch_monetization_types")]
    public string? WithWatchMonetizationTypes { get; set; } = null;

    /// <summary>
    /// Use in conjunction with <see cref="WatchRegion"/>, can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    [AliasAs("with_watch_providers")]
    public string? WithWatchProvíders { get; set; } = null;

    [AliasAs("without_companies")]
    public string? WithoutCompanies { get; set; } = null;

    [AliasAs("without_genres")]
    public string? WithoutGenres { get; set; } = null;

    [AliasAs("without_keywords")]
    public string? WithoutKeywords { get; set; } = null;

    [AliasAs("without_watch_providers")]
    public string? WithoutWatchProviders { get; set; } = null;

    /// <summary>
    /// Possible values are: [0, 1, 2, 3, 4, 5, 6], can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    [AliasAs("with_type")]
    public string? WithType { get; set; } = null;
}