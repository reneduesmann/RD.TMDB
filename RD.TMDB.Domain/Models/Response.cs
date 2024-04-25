namespace RD.TMDB.Domain.Models;

public class Response
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("status_code")]
    public int StatusCode { get; set; }

    [JsonPropertyName("status_message")]
    public string? StatusMessage { get; set; }
}
