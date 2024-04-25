namespace RD.TMDB.Domain.Models.TvEpisodes;

public class ExternalId
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("imdb_id")]
    public string? ImdbId { get; set; }
    
    [JsonPropertyName("freebase_mid")]
    public string? FreebaseMid { get; set; }
    
    [JsonPropertyName("freebase_id")]
    public string? FreebaseId { get; set; }
    
    [JsonPropertyName("tvdb_id")]
    public int TvdbId { get; set; }
    
    [JsonPropertyName("tvrage_id")]
    public int TvRageId { get; set; }
    
    [JsonPropertyName("wikidata_id")]
    public string? WikidataId { get; set; }
}