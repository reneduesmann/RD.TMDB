using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Core.Providers.V4;

public sealed partial class TmdbV4Client
{
    private string? GetLanguage(Iso639_1? language)
        => this._enumCache.GetStringValue(language ?? this.DefaultLanguage);

    private string? GetEnumValue<TEnum>(TEnum? value) where TEnum : struct, Enum
    {
        return value is null
            ? string.Empty
            : this._enumCache.GetStringValue(value);
    }
}
