using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

/// <summary>
/// Actions for an item.
/// </summary>
public enum ItemAction
{
    /// <summary>
    /// Default value, when the action is not existing.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Change action is added.
    /// </summary>
    [StringValue("added")]
    Added,

    /// <summary>
    /// Change action is updated.
    /// </summary>
    [StringValue("updated")]
    Updated,

    /// <summary>
    /// Change action is deleted.
    /// </summary>
    [StringValue("deleted")]
    Deleted
}