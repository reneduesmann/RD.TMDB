using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Shared;

public class Person : IKnownFor
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("original_name")]
    public string? OriginalName { get; set; }

    [JsonPropertyName("media_type")]
    public MediaType MediaType { get; set; } = MediaType.Person;
    
    [JsonPropertyName("adult")]
    public bool Adult { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("popularity")]
    public double Popularity { get; set; }
    
    [JsonPropertyName("gender")]
    public Gender Gender { get; set; }
    
    [JsonPropertyName("known_for_department")]
    public Department KnownForDepartment { get; set; }
    
    [JsonPropertyName("profile_path")]
    public string? ProfilePath { get; set; }

    [JsonPropertyName("known_for")]
    public IReadOnlyList<IKnownFor> KnownFor { get; set; } = [];
}