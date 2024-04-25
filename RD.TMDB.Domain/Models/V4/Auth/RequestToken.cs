namespace RD.TMDB.Domain.Models.V4.Auth;

public class RequestToken
{
    [JsonPropertyName("request_token")]
    public string? Token { get; set; }
    
    [JsonPropertyName("status_code")]
    public int StatusCode { get; set; }
    
    [JsonPropertyName("status_message")]
    public string? StatusMessage { get; set; }
    
    [JsonPropertyName("success")]
    public bool Success { get; set; }
}