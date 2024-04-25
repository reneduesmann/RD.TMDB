namespace RD.TMDB.Domain.Models.Lists;

public class AddMovieRequest
{
    [JsonPropertyName("media_id")]
    public int MediaId { get; }

    public AddMovieRequest(int mediaId)
    {
        this.MediaId = mediaId;
    }
}
