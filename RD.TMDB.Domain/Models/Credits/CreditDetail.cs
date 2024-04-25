using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Domain.Models.Credits;

public class CreditDetail
{
    [JsonPropertyName("credit_type")]
    public CreditType CreditType { get; set; }
    
    [JsonPropertyName("department")]
    public string? Department { get; set; }
    
    [JsonPropertyName("job")]
    public string? Job { get; set; }
    
    [JsonPropertyName("media")]
    public ICreditMedia? Media { get; set; }
    
    [JsonPropertyName("media_type")]
    public MediaType MediaType { get; set; }
    
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    [JsonPropertyName("person")]
    public Person? Person { get; set; }
}