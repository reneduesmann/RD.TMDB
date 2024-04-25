namespace RD.TMDB.Domain.Models.Certifications;

public class CertificationContainer
{
    [JsonPropertyName("certifications")]
    public Dictionary<string, IReadOnlyList<CertificationItem>> Certifications { get; set; } = [];
}
