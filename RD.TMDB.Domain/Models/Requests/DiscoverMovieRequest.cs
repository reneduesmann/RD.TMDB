using RD.TMDB.Domain.Enums;
using Refit;

namespace RD.TMDB.Domain.Models.Requests;

public class DiscoverMovieRequest
{
    /// <summary>
    /// Use in conjunction with <see cref="Region"/>.
    /// </summary>
    public string? Certification { get; set; } = null;

    /// <summary>
    /// Use in conjunction with <see cref="Region"/>.
    /// </summary>
    public string? CertificationGte { get; set; } = null;

    /// <summary>
    /// Use in conjunction with <see cref="Region"/>.
    /// </summary>
    public string? CertificationLte { get; set; } = null;

    /// <summary>
    /// Use in conjunction with the <see cref="Certification"/>, <see cref="CertificationGte"/> 
    /// and <see cref="CertificationLte"/> filters.
    /// </summary>
    public Iso3166_1? CertificationCountry { get; set; } = null;

    public bool? IncludeAdult { get; set; } = null;

    public bool? IncludeVideo { get; set; } = null;

    public Iso639_1? Language { get; set; } = null;

    public int? Page { get; set; } = null;

    public int? PrimaryReleaseYear { get; set; } = null;

    public DateOnly? PrimaryReleaseDateGte { get; set; } = null;

    public DateOnly? PrimaryReleaseDateLte { get; set; } = null;

    public string? Region { get; set; } = null;

    public DateOnly? ReleaseDateGte { get; set; } = null;

    public DateOnly? ReleaseDateLte { get; set; } = null;

    public DiscoverMovieSort? SortBy { get; set; } = null;

    public double? VoteAverageGte { get; set; } = null;

    public double? VoteAverageLte { get; set; } = null;

    public double? VoteCountGte { get; set; } = null;

    public double? VoteCountLte { get; set; } = null;

    /// <summary>
    /// Use in conjunction with <see cref="WithWatchMonetizationTypes"/> or 
    /// <see cref="WithWatchProviders"/>.
    /// </summary>
    public string? WatchRegion { get; set; } = null;

    /// <summary>
    /// Can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    public string? WithCast { get; set; } = null;

    /// <summary>
    /// Can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    public string? WithCompanies { get; set; } = null;

    /// <summary>
    /// Can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    public string? WithCrew { get; set; } = null;

    /// <summary>
    /// Can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    public string? WithGenres { get; set; } = null;

    /// <summary>
    /// Can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    public string? WithKeywords { get; set; } = null;

    public Iso3166_1? WithOriginCountry { get; set; } = null;

    public Iso639_1? WithOriginLanguage { get; set; } = null;

    /// <summary>
    /// Can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    public string? WithPeople { get; set; } = null;

    /// <summary>
    /// Possible values are: [1, 2, 3, 4, 5, 6] can be a comma (AND) or pipe (OR) separated query, 
    /// can be used in conjunction with <see cref="Region"/>.
    /// </summary>
    public string? WithReleaseType { get; set; } = null;

    public int? WithRuntimeGte { get; set; } = null;

    public int? WithRuntimeLte { get; set; } = null;

    /// <summary>
    /// Possible values are: [flatrate, free, ads, rent, buy] use in conjunction 
    /// with <see cref="WatchRegion"/>, can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    public string? WithWatchMonetizationTypes { get; set; } = null;

    /// <summary>
    /// Use in conjunction with <see cref="WatchRegion"/>, can be a comma (AND) or pipe (OR) separated query.
    /// </summary>
    public string? WithWatchProviders { get; set; } = null;

    public string? WithoutCompanies { get; set; } = null;

    public string? WithoutGenres { get; set; } = null;

    public string? WithoutKeywords { get; set; } = null;

    public string? WithoutWatchProviders { get; set; } = null;

    public int? Year { get; set; } = null;
}
