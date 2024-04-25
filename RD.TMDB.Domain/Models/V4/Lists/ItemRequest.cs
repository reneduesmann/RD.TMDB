namespace RD.TMDB.Domain.Models.V4.Lists;

public class ItemRequest
{
    [JsonPropertyName("media_type")]
    public string MediaType { get; }

    [JsonPropertyName("media_id")]
    public int MediaId { get; }

    public ItemRequest(string mediaType, int mediaId)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(mediaType);

        this.MediaType = mediaType;
        this.MediaId = mediaId;
    }
}
