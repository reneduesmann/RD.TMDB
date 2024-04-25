using RD.TMDB.Domain.Models.Images;

namespace RD.TMDB.Domain.Models.Changes;

public class ImageContainer
{
    [JsonPropertyName("poster")]
    public ImageBase? Poster { get; set; }

    [JsonPropertyName("backdrop")]
    public ImageBase? Backdrop { get; set; }
}
