namespace RD.TMDB.Domain.Models.Genres;

public class GenreContainer
{
    [JsonPropertyName("genres")]
    public IReadOnlyList<Genre> Genres { get; set; } = [];
}