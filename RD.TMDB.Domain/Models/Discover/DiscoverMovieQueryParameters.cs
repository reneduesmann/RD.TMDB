using Refit;

namespace RD.TMDB.Domain.Models.Discover;

public class DiscoverMovieQueryParameters
{
    /// <summary>
    /// Use in conjunction with <see cref="Region"/>.
    /// </summary>
    [AliasAs("certification")]
    public string? Certification { get; set; } = null;

    /// <summary>
    /// Use in conjunction with <see cref="Region"/>.
    /// </summary>
    [AliasAs("certification.gte")]
    public string? CertificationGte { get; set; } = null;

    /// <summary>
    /// Use in conjunction with <see cref="Region"/>.
    /// </summary>
    [AliasAs("certification.lte")]
    public string? CertificationLte { get; set; } = null;

    /// <summary>
    /// Use in conjunction with the <see cref="Certification"/>, <see cref="CertificationGte"/> 
    /// and <see cref="CertificationLte"/> filters.
    /// </summary>
    [AliasAs("certification_country")]
    public string? CertificationCountry { get; set; } = null;

    [AliasAs("include_adult")]
    public bool? IncludeAdult { get; set; } = null;

    [AliasAs("include_video")]
    public bool? IncludeVideo { get; set; } = null;

    [AliasAs("language")]
    public string? Language { get; set; } = null;

    [AliasAs("page")]
    public int? Page { get; set; } = null;

    [AliasAs("primary_release_year")]
    public int? PrimaryReleaseYear { get; set; } = null;

    [AliasAs("primary_release_date.gte")]
    public string? PrimaryReleaseDateGte { get; set; } = null;

    [AliasAs("primary_release_date.lte")]
    public string? PrimaryReleaseDateLte { get; set; } = null;

    [AliasAs("region")]
    public string? Region { get; set; } = null;

    [AliasAs("release_date.gte")]
    public string? ReleaseDateGte { get; set; } = null;

    [AliasAs("release_date.lte")]
    public string? ReleaseDateLte { get; set; } = null;

    [AliasAs("sort_by")]
    public string? SortBy { get; set; } = null;
    
    [AliasAs("vote_average.gte")]
    public double? VoteAverageGte { get; set; } = null;

    [AliasAs("vote_average.lte")]
    public double? VoteAverageLte { get; set; } = null;

    [AliasAs("vote_count.gte")]
    public double? VoteCountGte { get; set; } = null;

    [AliasAs("vote_count.lte")]
    public double? VoteCountLte { get; set; } = null;

    /// <summary>
    /// Use in conjunction with <see cref="WithWatchMonetizationTypes"/> or 
    /// <see cref="WithWatchProviders"/>.
    /// </summary>
    [AliasAs("watch_region")]
    public string? WatchRegion { get; set; } = null;

    /// <summary>
    /// Can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    [AliasAs("with_cast")]
    public string? WithCast { get; set; } = null;

    /// <summary>
    /// Can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    [AliasAs("with_companies")]
    public string? WithCompanies { get; set; } = null;

    /// <summary>
    /// Can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    [AliasAs("with_crew")]
    public string? WithCrew { get; set; } = null;

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

    [AliasAs("with_origin_country")]
    public string? WithOriginCountry { get; set; } = null;

    [AliasAs("with_original_language")]
    public string? WithOriginLanguage { get; set; } = null;

    /// <summary>
    /// Can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    [AliasAs("with_people")]
    public string? WithPeople { get; set; } = null;

    /// <summary>
    /// Possible values are: [1, 2, 3, 4, 5, 6] can be a comma (AND) or pipe (OR) separated query, 
    /// can be used in conjunction with <see cref="Region"/>.
    /// </summary>
    [AliasAs("with_release_type")]
    public string? WithReleaseType { get; set; } = null;

    [AliasAs("with_runtime.gte")]
    public int? WithRuntimeGte { get; set; } = null;

    [AliasAs("with_runtime.lte")]
    public int? WithRuntimeLte { get; set; } = null;

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
    public string? WithWatchProviders { get; set; } = null;

    [AliasAs("without_companies")]
    public string? WithoutCompanies { get; set; } = null;

    [AliasAs("without_genres")]
    public string? WithoutGenres { get; set; } = null;

    [AliasAs("without_keywords")]
    public string? WithoutKeywords { get; set; } = null;

    [AliasAs("without_watch_providers")]
    public string? WithoutWatchProviders { get; set; } = null;

    [AliasAs("year")]
    public int? Year { get; set; } = null;
}
