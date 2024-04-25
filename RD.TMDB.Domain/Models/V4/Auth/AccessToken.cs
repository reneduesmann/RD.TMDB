namespace RD.TMDB.Domain.Models.V4.Auth;

public class AccessToken
{
    [JsonPropertyName("account_id")]
    public string? AccountId { get; set; }
    
    [JsonPropertyName("access_token")]
    public string? Token { get; set; }
    
    [JsonPropertyName("success")]
    public bool Success { get; set; }
    
    [JsonPropertyName("status_message")]
    public string? StatusMessage { get; set; }
    
    [JsonPropertyName("status_code")]
    public int StatusCode { get; set; }
}