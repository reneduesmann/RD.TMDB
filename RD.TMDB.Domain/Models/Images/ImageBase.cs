using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Images;

public class ImageBase
{
    [JsonPropertyName("aspect_ratio")]
    public double AspectRatio { get; set; }
    
    [JsonPropertyName("height")]
    public int Height { get; set; }
    
    [JsonPropertyName("iso_639_1")]
    public Iso639_1 Language { get; set; }
    
    [JsonPropertyName("file_path")]
    public string? FilePath { get; set; }
    
    [JsonPropertyName("vote_average")]
    public double VoteAverage { get; set; }
    
    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }
    
    [JsonPropertyName("width")]
    public int Width { get; set; }
}
