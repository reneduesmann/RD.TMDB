using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Changes;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : IChangesProvider
{
    private IChangesApi? _changesApi;

    private IChangesApi ChangesApi => this._changesApi ??= this.CreateRefitInterface<IChangesApi>();

    public async Task<ResultContainer<ChangedItem>> GetMovieChangeListAsync(DateOnly? startDate = null, DateOnly? endDate = null,
        int? page = null, CancellationToken cancellationToken = default)
    {
        (string? startDateToUse, string? endDateToUse) = GetDates(startDate, endDate);

        return await this.ChangesApi.GetMovieChangeListAsync(startDateToUse, endDateToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<ChangedItem>> GetPersonChangeListAsync(DateOnly? startDate = null, DateOnly? endDate = null,
        int? page = null, CancellationToken cancellationToken = default)
    {
        (string? startDateToUse, string? endDateToUse) = GetDates(startDate, endDate);

        return await this.ChangesApi.GetPersonChangeListAsync(startDateToUse, endDateToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<ChangedItem>> GetTvShowChangeListAsync(DateOnly? startDate = null, DateOnly? endDate = null,
        int? page = null, CancellationToken cancellationToken = default)
    {
        (string? startDateToUse, string? endDateToUse) = GetDates(startDate, endDate);

        return await this.ChangesApi.GetTvShowChangeListAsync(startDateToUse, endDateToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }
}
