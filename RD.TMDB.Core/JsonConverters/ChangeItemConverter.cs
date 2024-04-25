using RD.Extensions.Enums.Contracts;
using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.AlternativeTitles;
using RD.TMDB.Domain.Models.Changes;
using RD.TMDB.Domain.Models.Companies;
using RD.TMDB.Domain.Models.Genres;
using RD.TMDB.Domain.Models.Keywords;
using RD.TMDB.Domain.Models.Shared;
using System.Text.Json;
using System.Text.Json.Serialization;
using static RD.TMDB.Domain.Configurations.ErrorMessage;

namespace RD.TMDB.Core.JsonConverters;

public sealed class ChangeItemConverter : JsonConverter<IChangeItem>
{
    private static JsonSerializerOptions? _newOptions;

    private readonly Dictionary<ChangeKey, Type> _mappingKeysWithTypes = new()
    {
        { ChangeKey.Images, typeof(ImageContainer) },
        { ChangeKey.PlotKeywords, typeof(Keyword) },
        { ChangeKey.Tagline, typeof(Tagline) },
        { ChangeKey.ReleaseDates, typeof(ReleaseDate) },
        { ChangeKey.AlternativeTitles, typeof(AlternativeTitle) },
        { ChangeKey.ProductionCompanies, typeof(Company) },
        { ChangeKey.CharacterNames, typeof(Character) },
        { ChangeKey.Genres, typeof(Genre) },
        { ChangeKey.Season, typeof(Domain.Models.Changes.TvSeason) },
        { ChangeKey.SeasonRegular, typeof(Domain.Models.Changes.TvSeason) },
        { ChangeKey.Episode, typeof(Domain.Models.Changes.TvEpisode) }
    };

    private readonly IEnumCache _enumCache;

    public ChangeItemConverter(IEnumCache enumCache)
    {
        this._enumCache = enumCache;
    }

    public override IChangeItem? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (!JsonElement.TryParseValue(ref reader, out JsonElement? jsonElement) || jsonElement is null)
        {
            return default;
        }

        string valuePropertyName = "value";
        string originalValuePropertyName = "original_value";

        jsonElement.Value.TryGetProperty(valuePropertyName, out JsonElement valueElement);
        jsonElement.Value.TryGetProperty(originalValuePropertyName, out JsonElement originalValueElement);

        if (_newOptions is null)
        {
            _newOptions = new(options);
            _newOptions.Converters.Remove(this);
        }

        IChangeItem? changeItem = this.GetChangeItem(jsonElement.Value, valueElement, originalValueElement);

        if(changeItem is null)
        {
            throw new InvalidOperationException(FailedToHandleChangeItem);
        }

        return changeItem;
    }

    public override void Write(Utf8JsonWriter writer, IChangeItem value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    private IChangeItem? GetChangeItem(JsonElement jsonElement, JsonElement valueElement, JsonElement originalValueElement)
    {
        JsonElement targetValueElement = valueElement.ValueKind == JsonValueKind.Undefined
            ? originalValueElement
            : valueElement;

        if (targetValueElement.ValueKind == JsonValueKind.Undefined)
        {
            return default;
        }

        switch (targetValueElement.ValueKind)
        {
            case JsonValueKind.Undefined:
                break;
            case JsonValueKind.Object:
                string keyPropertyName = "key";

                if (!jsonElement.TryGetProperty(keyPropertyName, out JsonElement keyElement))
                {
                    throw new JsonException(string.Format(PropertyNotFound, keyPropertyName));
                }

                if(string.IsNullOrWhiteSpace(keyElement.GetString()))
                {
                    return default;
                }

                ChangeKey targetChangeKey = this._enumCache.GetEnumValueByAttributeValue<ChangeKey, string>(keyElement.GetString()!);

                if(targetChangeKey == ChangeKey.Undefined)
                {
                    throw new NotSupportedException(string.Format(ChangeKeyNotFound, keyElement.GetString()));
                }

                if(!this._mappingKeysWithTypes.TryGetValue(targetChangeKey, out Type? changeItemType))
                {
                    throw new JsonException(string.Format(ChangeKeyNotSupported, targetChangeKey));
                }

                Type genericChangeItem = typeof(ChangeItem<>);
                Type constructedType = genericChangeItem.MakeGenericType(changeItemType);
                object? deserializedValue = jsonElement.Deserialize(constructedType, _newOptions);

                if(deserializedValue is null)
                {
                    throw new JsonException(string.Format(ChangeKeyDeserializationFailed, targetChangeKey));
                }

                return (IChangeItem)deserializedValue;
            case JsonValueKind.Array:
                JsonElement firstArrayElement = targetValueElement.EnumerateArray().FirstOrDefault();

                if(firstArrayElement.ValueKind == JsonValueKind.Undefined)
                {
                    return default;
                }

                Type? elementType = this.GetTypeFromValueKind(firstArrayElement.ValueKind);

                if(elementType is null)
                {
                    throw new NotSupportedException(string.Format(TypeNotSupported, firstArrayElement.ValueKind));
                }

                Type genericListType = typeof(List<>);
                Type constructedList = genericListType.MakeGenericType(elementType);
                Type genericChangeListItem = typeof(ChangeItem<>);
                Type constructedChangeListItem = genericChangeListItem.MakeGenericType(constructedList);

                object? deserializedList = jsonElement.Deserialize(constructedChangeListItem, _newOptions);

                if(deserializedList is null)
                {
                    throw new JsonException(string.Format(TypeDeserializationFailed, firstArrayElement.ValueKind));
                }

                return (IChangeItem)deserializedList;
            case JsonValueKind.String:
                return jsonElement.Deserialize<ChangeItem<string>>(_newOptions);
            case JsonValueKind.Number:
                return jsonElement.Deserialize<ChangeItem<double>>(_newOptions);
            case JsonValueKind.True:
            case JsonValueKind.False:
                return jsonElement.Deserialize<ChangeItem<bool>>(_newOptions);
            case JsonValueKind.Null:
                break;
        }

        return default;
    }

    private Type? GetTypeFromValueKind(JsonValueKind valueKind) => valueKind switch
    {
        JsonValueKind.String => typeof(string),
        JsonValueKind.Number => typeof(double),
        JsonValueKind.False => typeof(bool),
        JsonValueKind.True => typeof(bool),
        _ => throw new NotSupportedException(string.Format(TypeNotSupported, valueKind))
    };
}
