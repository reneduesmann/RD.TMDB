using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

/// <summary>
/// Define the sorting of results.
/// </summary>
public enum SortBy
{
    /// <summary>
    /// No sorting type will be applied.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Results will be sort as ascending for the created at value.
    /// </summary>
    [StringValue("created_at.asc")]
    Created_Asc,

    /// <summary>
    /// Results will be sort as descending for the created at value.
    /// </summary>
    [StringValue("created_at.desc")]
    Created_Desc
}