namespace RD.TMDB.Domain.Models.V4.Lists;

public class UpdateItemRequest : ItemRequest
{
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    public UpdateItemRequest(string mediaType, int mediaId) : base(mediaType, mediaId)
    {
    }
}
