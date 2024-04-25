namespace RD.TMDB.Domain.Models.Certifications;

public class CertificationItem
{
    [JsonPropertyName("certification")]
    public string? Certification { get; set; }

    [JsonPropertyName("meaning")]
    public string? Meaning { get; set; }

    [JsonPropertyName("order")]
    public int Order { get; set; }
}
