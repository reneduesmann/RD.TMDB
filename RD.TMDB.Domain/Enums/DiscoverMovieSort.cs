using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

public enum DiscoverMovieSort
{
    Undefined = 0,

    [StringValue("original_title.asc")]
    OriginalTile_Asc,

    [StringValue("original_title.desc")]
    OriginalTile_Desc,

    [StringValue("popularity.asc")]
    Popularity_Asc,

    [StringValue("popularity.desc")]
    Popularity_Desc,

    [StringValue("revenue.asc")]
    Revenue_Asc,

    [StringValue("revenue.desc")]
    Revenue_Desc,

    [StringValue("primary_release_date.asc")]
    PrimaryReleaseDate_Asc,

    [StringValue("primary_release_date.desc")]
    PrimaryReleaseDate_Desc,

    [StringValue("title.asc")]
    Title_Asc,

    [StringValue("title.desc")]
    Title_Desc,

    [StringValue("vote_average.asc")]
    VoteAverage_Asc,

    [StringValue("vote_average.desc")]
    VoteAverage_Desc,

    [StringValue("vote_count.asc")]
    VoteCount_Asc,

    [StringValue("vote_count.desc")]
    VoteCount_Desc
}