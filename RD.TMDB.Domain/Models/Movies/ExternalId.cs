namespace RD.TMDB.Domain.Models.Movies;

public class ExternalId
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("imdb_id")]
    public string? ImdbId { get; set; }
    
    [JsonPropertyName("wikidata_id")]
    public string? WikidataId { get; set; }
    
    [JsonPropertyName("facebook_id")]
    public string? FacebookId { get; set; }
    
    [JsonPropertyName("instagram_id")]
    public string? InstagramId { get; set; }
    
    [JsonPropertyName("twitter_id")]
    public string? TwitterId { get; set; }
}