namespace RD.TMDB.Domain.Models.Companies;

public class CompanyImageContainer
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("logos")]
    public IReadOnlyList<CompanyImage> Images { get; set; } = [];
}
