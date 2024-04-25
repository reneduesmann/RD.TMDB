using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Changes;

public interface IChangeItem
{
    string? Id { get; set; }

    ItemAction Action { get; set; }

    DateTimeOffset Time { get; set; }

    Iso639_1 Language { get; set; }

    Iso3166_1 Country { get; set; }
}
