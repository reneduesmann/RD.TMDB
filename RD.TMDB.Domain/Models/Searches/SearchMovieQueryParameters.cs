using Refit;

namespace RD.TMDB.Domain.Models.Searches;

public class SearchMovieQueryParameters
{
    [AliasAs("include_adult")]
    public bool? IncludeAdult { get; set; } = null;

    [AliasAs("language")]
    public string? Language { get; set; } = null;

    [AliasAs("primary_release_year")]
    public string? PrimaryReleaseYear { get; set; } = null;

    [AliasAs("page")]
    public int? Page { get; set; } = null;

    [AliasAs("region")]
    public string? Region { get; set; } = null;

    [AliasAs("year")]
    public string? Year { get; set; } = null;
}
