using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

/// <summary>
/// Types of department.
/// </summary>
public enum Department
{
    /// <summary>
    /// Default value, when the department is not existing.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Department is acting.
    /// </summary>
    [StringValue("Acting")]
    Acting,

    /// <summary>
    /// Department is actors.
    /// </summary>
    [StringValue("Actors")]
    Actors,

    /// <summary>
    /// Department is art.
    /// </summary>
    [StringValue("Art")]
    Art,

    /// <summary>
    /// Department is camera.
    /// </summary>
    [StringValue("Camera")]
    Camera,

    /// <summary>
    /// Department is costime and make-up.
    /// </summary>
    [StringValue("Costume & Make-Up")]
    CostumeAndMake_Up,

    /// <summary>
    /// Department is creator.
    /// </summary>
    [StringValue("Creator")]
    Creator,

    /// <summary>
    /// Department is crew.
    /// </summary>
    [StringValue("Crew")]
    Crew,

    /// <summary>
    /// Department is directing.
    /// </summary>
    [StringValue("Directing")]
    Directing,

    /// <summary>
    /// Department is editing.
    /// </summary>
    [StringValue("Editing")]
    Editing,

    /// <summary>
    /// Department is lighting.
    /// </summary>
    [StringValue("Lighting")]
    Lighting,

    /// <summary>
    /// Department is production.
    /// </summary>
    [StringValue("Production")]
    Production,

    /// <summary>
    /// Department is sound.
    /// </summary>
    [StringValue("Sound")]
    Sound,

    /// <summary>
    /// Department is visual effect.
    /// </summary>
    [StringValue("Visual Effects")]
    VisualEffects,

    /// <summary>
    /// Department is writing.
    /// </summary>
    [StringValue("Writing")]
    Writing
}