using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.Images;

namespace RD.TMDB.Domain.Models.Networks;

public class NetworkImage : ImageBase
{
    [JsonPropertyName("file_type")]
    public FileType FileType { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
