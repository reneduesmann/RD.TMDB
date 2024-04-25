namespace RD.TMDB.Domain.Models.Lists;

public class RemoveMovieRequest
{
    [JsonPropertyName("media_id")]
    public int MediaId { get; set; }

    public RemoveMovieRequest(int mediaId)
    {
        this.MediaId = mediaId;
    }
}
