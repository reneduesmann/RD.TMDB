using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

[Flags]
public enum TvSeasonInformation
{
    Undefined = 0,

    [StringValue("account_states")]
    AccountStates = 1 << 0,

    [StringValue("aggregate_credits")]
    AggregateCredits = 1 << 1,

    [StringValue("credits")]
    Credits = 1 << 2,

    [StringValue("external_ids")]
    ExternalIds = 1 << 3,

    [StringValue("images")]
    Images = 1 << 4,

    [StringValue("translations")]
    Translations = 1 << 5,

    [StringValue("videos")]
    Videos = 1 << 6,

    [StringValue("watch/providers")]
    WatchProviders = 1 << 7
}