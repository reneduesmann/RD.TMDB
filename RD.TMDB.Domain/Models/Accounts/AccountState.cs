namespace RD.TMDB.Domain.Models.Accounts;

public class AccountState
{
    [JsonPropertyName("favorite")]
    public bool Favorite { get; set; }
    
    [JsonPropertyName("rated")]
    public bool Rated { get; set; }

    [JsonIgnore]
    public double RatedValue { get; set; }

    [JsonPropertyName("watchlist")]
    public bool Watchlist { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }
}