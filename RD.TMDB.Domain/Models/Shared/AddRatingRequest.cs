namespace RD.TMDB.Domain.Models.Shared;

public class AddRatingRequest
{
    [JsonPropertyName("value")]
    public double Value { get; }

    public AddRatingRequest(double value)
    {
        Value = value;
    }
}
