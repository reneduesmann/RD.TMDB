using RD.Extensions.Enums.Contracts;
using RD.TMDB.Domain.Enums;
using System.Text.Json;
using System.Text.Json.Serialization;
using static RD.TMDB.Domain.Configurations.EnumConstant;

namespace RD.TMDB.Core.JsonConverters;

public sealed class CountryAndLanguageConverter : JsonConverter<CountryAndLanguage>
{
    private readonly IEnumCache _enumCache;

    public CountryAndLanguageConverter(IEnumCache enumCache)
    {
        this._enumCache = enumCache;
    }

    public override CountryAndLanguage Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? value = reader.GetString();

        if(string.IsNullOrWhiteSpace(value))
        {
            return default;
        }

        string[] values = value.Split('-');

        Iso639_1 language = this._enumCache.GetEnumValueByAttributeValue<Iso639_1, string>(values[0]);
        Iso3166_1 country = this._enumCache.GetEnumValueByAttributeValue<Iso3166_1, string>(values[1]);

        if(language == Iso639_1.Undefined || country == Iso3166_1.Undefined)
        {
            return CountryAndLanguage.Undefined;
        }

        foreach (CountryAndLanguage countryAndLanguage in Enum.GetValues<CountryAndLanguage>())
        {
            if(countryAndLanguage == CountryAndLanguage.Undefined)
            {
                continue;
            }

            List<KeyValuePair<string, object>> valuePairs = this._enumCache.GetKeyValuePairs(countryAndLanguage);

            KeyValuePair<string, object> countryPair = valuePairs.FirstOrDefault(x => x.Key == CountryKey);
            KeyValuePair<string, object> languagePair = valuePairs.FirstOrDefault(x => x.Key == LanguageKey);

            Iso639_1 languageValue = (Iso639_1)languagePair.Value;
            Iso3166_1 countryValue = (Iso3166_1)countryPair.Value;

            if(languageValue == language && countryValue == country)
            {
                return countryAndLanguage;
            }
        }

        return CountryAndLanguage.Undefined;
    }

    public override void Write(Utf8JsonWriter writer, CountryAndLanguage value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
