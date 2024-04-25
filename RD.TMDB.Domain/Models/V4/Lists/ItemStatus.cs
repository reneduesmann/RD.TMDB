using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.V4.Lists;

public class ItemStatus : Response
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("media_id")]
    public int MediaId { get; set; }
    
    [JsonPropertyName("media_type")]
    public MediaType MediaType { get; set; }
}