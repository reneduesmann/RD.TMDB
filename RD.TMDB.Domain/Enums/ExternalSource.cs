using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

public enum ExternalSource
{
    Undefined,

    [StringValue("imdb_id")]
    IMDB,

    [StringValue("facebook_id")]
    Facebook,

    [StringValue("instagram_id")]
    Instagram,

    [StringValue("tvdb_id")]
    TvDb,

    [StringValue("tiktok_id")]
    TikTok,

    [StringValue("twitter_id")]
    Twitter,

    [StringValue("wikidata_id")]
    Wikidata,

    [StringValue("youtube_id")]
    Youtube
}