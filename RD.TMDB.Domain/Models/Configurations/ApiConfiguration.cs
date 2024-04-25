using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Configurations;

public class ApiConfiguration
{
    [JsonPropertyName("images")]
    public Image? Images { get; set; }

    [JsonPropertyName("change_keys")]
    public IReadOnlyList<ChangeKey> ChangeKeys { get; set; } = [];
}