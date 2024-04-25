using RD.TMDB.Domain.Models.Reviews;

namespace RD.TMDB.Core.ApiContracts;

public interface IReviewsApi
{
    /// <summary>
    /// Retrieve the details of a movie or TV show review.
    /// </summary>
    /// <param name="reviewId"></param>
    /// <returns></returns>
    [Get("/review/{reviewId}")]
    Task<ReviewDetail> GetDetailsAsync(
        string reviewId,
        CancellationToken cancellationToken = default);
}
