using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient
{
    private string? GetEnumValue<TEnum>(TEnum? value) where TEnum : struct, Enum
    {
        return value is null
            ? string.Empty
            : this._enumCache.GetStringValue(value);
    }

    private string? GetLanguage(Iso639_1? language)
        => this._enumCache.GetStringValue(language ?? this.DefaultLanguage);

    private string? GetCountry(Iso3166_1? country)
        => this._enumCache.GetStringValue(country ?? this.DefaultCountry);

    private static (string? startDate, string? endDate) GetDates(DateOnly? startDate, DateOnly? endDate)
    {
        string? startDateToUse = startDate?.ToString("yyyy-MM-dd");
        string? endDateToUse = endDate?.ToString("yyyy-MM-dd");

        return (startDateToUse, endDateToUse);
    }

    private IEnumerable<string>? GetLanguages(IEnumerable<Iso639_1>? includeImageLanguages)
    {
        return includeImageLanguages is null || !includeImageLanguages.Any()
            ? null
            : includeImageLanguages
                .Select(x => this._enumCache.GetStringValue(x)!)
                .Where(x => !string.IsNullOrWhiteSpace(x));
    }

    private List<string> GetAdditionalInformations<TEnum>(TEnum enumValue)
        where TEnum : struct, Enum
    {
        List<string> additionalInformations = [];

        foreach (TEnum information in Enum.GetValues<TEnum>())
        {
            if (enumValue.HasFlag(information))
            {
                string? value = this._enumCache.GetStringValue(information);

                if (string.IsNullOrWhiteSpace(value))
                {
                    continue;
                }

                additionalInformations.Add(value);
            }
        }

        return additionalInformations;
    }
}
