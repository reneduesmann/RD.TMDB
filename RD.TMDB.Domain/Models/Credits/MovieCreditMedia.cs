using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Domain.Models.Credits;

public class MovieCreditMedia : Movie, ICreditMedia
{
    [JsonPropertyName("character")]
    public string? Character { get; set; }
}