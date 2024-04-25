namespace RD.TMDB.Domain.Models.Changes;

public class Character
{
    [JsonPropertyName("person_id")]
    public int PersonId { get; set; }

    [JsonPropertyName("character")]
    public string? Name { get; set; }

    [JsonPropertyName("cast_id")]
    public int CastId { get; set; }

    [JsonPropertyName("credit_id")]
    public string? CreditId { get; set; }
}
