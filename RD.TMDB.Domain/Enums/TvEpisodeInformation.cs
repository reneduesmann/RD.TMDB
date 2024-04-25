using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

[Flags]
public enum TvEpisodeInformation
{
    Undefined = 0,

    [StringValue("account_states")]
    AccountStates = 1 << 0,

    [StringValue("credits")]
    Credits = 1 << 1,

    [StringValue("external_ids")]
    ExternalIds = 1 << 2,

    [StringValue("images")]
    Images = 1 << 3,

    [StringValue("translations")]
    Translations = 1 << 4,

    [StringValue("videos")]
    Videos = 1 << 5
}