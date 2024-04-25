﻿using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Credits;

public class Crew
{
    [JsonPropertyName("adult")]
    public bool Adult { get; set; }
    
    [JsonPropertyName("gender")]
    public Gender Gender { get; set; }
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("known_for_department")]
    public Department KnownForDepartment { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("original_name")]
    public string? OriginalName { get; set; }
    
    [JsonPropertyName("popularity")]
    public double Popularity { get; set; }
    
    [JsonPropertyName("profile_path")]
    public string? ProfilePath { get; set; }
    
    [JsonPropertyName("credit_id")]
    public string? CreditId { get; set; }
    
    [JsonPropertyName("department")]
    public Department Department { get; set; }
    
    [JsonPropertyName("job")]
    public string? Job { get; set; }
}
