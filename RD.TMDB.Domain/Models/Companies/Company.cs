using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Companies;

public class Company
{
    /// <summary>
    /// Name of the company.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Id of the company.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// Path to the logo of the company.
    /// </summary>
    [JsonPropertyName("logo_path")]
    public string? LogoPath { get; set; }

    [JsonPropertyName("origin_country")]
    public Iso3166_1 OriginCountry { get; set; }
}
