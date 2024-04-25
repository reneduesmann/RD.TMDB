namespace RD.TMDB.Domain.Models.Changes;

public class TvSeason
{
    [JsonPropertyName("season_id")]
    public int SeasonId { get; set; }

    [JsonPropertyName("season_number")]
    public int SeasonNumber { get; set; }

    [JsonPropertyName("add_to_every_season")]
    public bool AddToEverySeason { get; set; }
    
    [JsonPropertyName("character")]
    public string? Character { get; set; }
    
    [JsonPropertyName("credit_id")]
    public string? CreditId { get; set; }
    
    [JsonPropertyName("order")]
    public int Order { get; set; }
    
    [JsonPropertyName("person_id")]
    public int PersonId { get; set; }
}