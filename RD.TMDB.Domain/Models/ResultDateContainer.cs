using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Domain.Models;

public class ResultDateContainer<TResult> : ResultContainer<TResult> where TResult : class
{
    [JsonPropertyName("dates")]
    public Dates? Dates { get; set; }
}
