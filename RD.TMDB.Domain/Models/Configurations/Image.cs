using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Configurations;

public class Image
{
    [JsonPropertyName("base_url")]
    public string? BaseUrl { get; set; }
    
    [JsonPropertyName("secure_base_url")]
    public string? SecureBaseUrl { get; set; }

    [JsonPropertyName("backdrop_sizes")]
    public IReadOnlyList<BackdropSize> BackdropSizes { get; set; } = [];

    [JsonPropertyName("logo_sizes")]
    public IReadOnlyList<LogoSize> LogoSizes { get; set; } = [];

    [JsonPropertyName("poster_sizes")]
    public IReadOnlyList<PosterSize> PosterSizes { get; set; } = [];

    [JsonPropertyName("profile_sizes")]
    public IReadOnlyList<ProfileSize> ProfileSizes { get; set; } = [];

    [JsonPropertyName("still_sizes")]
    public IReadOnlyList<StillSize> StillSizes { get; set; } = [];
}
