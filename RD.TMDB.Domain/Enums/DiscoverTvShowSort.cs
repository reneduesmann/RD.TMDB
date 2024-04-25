using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

public enum DiscoverTvShowSort
{
    Undefined = 0,

    [StringValue("first_air_date.asc")]
    FirstAirDate_Asc,

    [StringValue("first_air_date.desc")]
    FirstAirDate_Desc,

    [StringValue("name.asc")]
    Name_Asc,

    [StringValue("name.desc")]
    Name_Desc,

    [StringValue("original_name.asc")]
    OriginalName_Asc,

    [StringValue("original_name.desc")]
    OriginalName_Desc,

    [StringValue("popularity.asc")]
    Popularity_Asc,

    [StringValue("popularity.desc")]
    Popularity_Desc,

    [StringValue("vote_average.asc")]
    VoteAverage_Asc,

    [StringValue("vote_average.desc")]
    VoteAverage_Desc,

    [StringValue("vote_count.asc")]
    VoteCount_Asc,

    [StringValue("vote_count.desc")]
    VoteCount_Desc
}