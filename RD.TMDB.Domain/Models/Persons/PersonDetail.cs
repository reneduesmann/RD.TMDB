using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Persons;

public class PersonDetail : PersonDetailAppendToResponseData
{
    [JsonPropertyName("adult")]
    public bool Adult { get; set; }

    [JsonPropertyName("also_known_as")]
    public IReadOnlyList<string> AlsoKnownAs { get; set; } = [];
    
    [JsonPropertyName("biography")]
    public string? Biography { get; set; }
    
    [JsonPropertyName("birthday")]
    public DateOnly Birthday { get; set; }
    
    [JsonPropertyName("deathday")]
    public DateOnly? Deathday { get; set; }
    
    [JsonPropertyName("gender")]
    public Gender Gender { get; set; }
    
    [JsonPropertyName("homepage")]
    public Uri? Homepage { get; set; }
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("imdb_id")]
    public string? ImdbId { get; set; }
    
    [JsonPropertyName("known_for_department")]
    public Department KnownForDepartment { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("place_of_birth")]
    public string? PlaceOfBirth { get; set; }
    
    [JsonPropertyName("popularity")]
    public double Popularity { get; set; }
    
    [JsonPropertyName("profile_path")]
    public string? ProfilePath { get; set; }
}