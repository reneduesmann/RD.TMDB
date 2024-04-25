using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

/// <summary>
/// Types of a credit.
/// </summary>
public enum CreditType
{
    /// <summary>
    /// Default value, when the credit type is not existing.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Credit type is cast.
    /// </summary>
    [StringValue("cast")]
    Cast
}