using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Authentications;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : IAuthenticationProvider
{
    private IAuthenticationApi? _authenticationApi;

    private IAuthenticationApi AuthenticationApi => this._authenticationApi ??= this.CreateRefitInterface<IAuthenticationApi>();

    public async Task<GuestSession> CreateGuestSessionAsync(CancellationToken cancellationToken = default)
    {
        return await this.AuthenticationApi.CreateGuestSessionAsync(cancellationToken).ConfigureAwait(false);
    }

    public async Task<RequestToken> CreateRequestTokenAsync(CancellationToken cancellationToken = default)
    {
        return await this.AuthenticationApi.CreateRequestTokenAsync(cancellationToken).ConfigureAwait(false);
    }

    public async Task<Session> CreateSessionAsync(CreateSessionRequest createSessionRequest, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(createSessionRequest);

        return await this.AuthenticationApi.CreateSessionAsync(createSessionRequest, cancellationToken).ConfigureAwait(false);
    }

    public async Task<Session> CreateSessionAsync(string requestToken, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(requestToken);

        return await this.CreateSessionAsync(new CreateSessionRequest(requestToken), cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<SessionWithLogin> CreateSessionWithLoginRequestAsync(CreateSessionWithLoginRequest createSessionWithLoginRequest,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(createSessionWithLoginRequest);

        return await this.AuthenticationApi.CreateSessionWithLoginRequestAsync(createSessionWithLoginRequest, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<SessionWithLogin> CreateSessionWithLoginRequestAsync(string username, string password, string requestToken,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(username);
        ArgumentException.ThrowIfNullOrWhiteSpace(password);
        ArgumentException.ThrowIfNullOrWhiteSpace(requestToken);

        CreateSessionWithLoginRequest createSessionWithLoginRequest = new(username, password, requestToken);

        return await this.CreateSessionWithLoginRequestAsync(createSessionWithLoginRequest, cancellationToken).ConfigureAwait(false);
    }

    public async Task<DeleteSession> DeleteSessionAsync(DeleteSessionRequest deleteSessionRequest, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(deleteSessionRequest);

        return await this.AuthenticationApi.DeleteSessionAsync(deleteSessionRequest, cancellationToken).ConfigureAwait(false);
    }

    public async Task<DeleteSession> DeleteSessionAsync(string sessionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(sessionId);

        return await this.DeleteSessionAsync(new DeleteSessionRequest(sessionId), cancellationToken).ConfigureAwait(false);
    }

    public async Task<Response> ValidateKeyAsync(CancellationToken cancellationToken = default)
    {
        return await this.AuthenticationApi.ValidateKeyAsync(cancellationToken).ConfigureAwait(false);
    }
}
