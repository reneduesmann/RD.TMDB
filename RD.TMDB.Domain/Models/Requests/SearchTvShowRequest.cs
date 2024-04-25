using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Requests;

public class SearchTvShowRequest
{
    public bool? IncludeAdult { get; set; } = null;

    public Iso639_1? Language { get; set; } = null;

    public int? FirstAirDateYear { get; set; } = null;

    public int? Page { get; set; } = null;

    public int? Year { get; set; } = null;
}
