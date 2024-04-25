using System.Text.Json;
using System.Text.Json.Serialization;

namespace RD.TMDB.Core.JsonConverters;

public sealed class DateOnlyConverter : JsonConverter<DateOnly>
{
    public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? value = reader.GetString();

        if(string.IsNullOrWhiteSpace(value))
        {
            return default;
        }

        if(DateOnly.TryParse(value, out DateOnly date))
        {
            return date;
        }

        if(DateTime.TryParse(value, out DateTime dateTime))
        {
            return DateOnly.FromDateTime(dateTime);
        }

        return default;
    }

    public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
