using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Models.Reviews;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : IReviewProvider
{
    private IReviewsApi? _reviewsApi;

    private IReviewsApi ReviewsApi => this._reviewsApi ??= this.CreateRefitInterface<IReviewsApi>();

    public async Task<ReviewDetail> GetReviewDetailsAsync(string reviewId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(reviewId);

        return await this.ReviewsApi.GetDetailsAsync(reviewId, cancellationToken).ConfigureAwait(false);
    }
}
