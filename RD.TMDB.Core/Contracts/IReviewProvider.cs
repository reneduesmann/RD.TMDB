using RD.TMDB.Domain.Models.Reviews;

namespace RD.TMDB.Core.Contracts;

public interface IReviewProvider
{
    Task<ReviewDetail> GetReviewDetailsAsync(string reviewId, CancellationToken cancellationToken = default);
}