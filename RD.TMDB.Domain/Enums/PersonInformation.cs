using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

[Flags]
public enum PersonInformation
{
    Undefined = 0,

    [StringValue("changes")]
    Changes = 1 << 0,

    [StringValue("combined_credits")]
    CombinedCredits = 1 << 1,

    [StringValue("external_ids")]
    ExternalIds = 1 << 2,

    [StringValue("images")]
    Images = 1 << 3,

    [StringValue("movie_credits")]
    MovieCredits = 1 << 4,

    [StringValue("tv_credits")]
    TvShowCredits = 1 << 5,

    [StringValue("translations")]
    Translations = 1 << 6
}