using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Companies;

public class CompanyDetail
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    
    [JsonPropertyName("headquarters")]
    public string? Headquarters { get; set; }
    
    [JsonPropertyName("homepage")]
    public string? Homepage { get; set; }
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("logo_path")]
    public string? LogoPath { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("origin_country")]
    public Iso3166_1 OriginCountry { get; set; }
    
    [JsonPropertyName("parent_company")]
    public Company? ParentCompany { get; set; }
}