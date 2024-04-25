using Refit;

namespace RD.TMDB.Core.ApiContracts;

public class SearchTvShowQueryParameters
{
    [AliasAs("include_adult")]
    public bool? IncludeAdult { get; set; } = null;

    [AliasAs("language")]
    public string? Language { get; set; } = null;

    [AliasAs("first_air_date_year")]
    public int? FirstAirDateYear { get; set; } = null;

    [AliasAs("page")]
    public int? Page { get; set; } = null;

    [AliasAs("year")]
    public string? Year { get; set; } = null;
}