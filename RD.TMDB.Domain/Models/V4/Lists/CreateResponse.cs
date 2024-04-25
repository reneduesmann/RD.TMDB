namespace RD.TMDB.Domain.Models.V4.Lists;

public class CreateResponse : Response
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
}
