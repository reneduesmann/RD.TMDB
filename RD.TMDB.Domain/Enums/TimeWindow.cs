using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

public enum TimeWindow
{
    Undefined = 0,

    [StringValue("day")]
    Day,

    [StringValue("week")]
    Week
}