using RD.TMDB.Core.ApiContracts.V4;
using RD.TMDB.Core.Contracts.V4;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.V4.Auth;

namespace RD.TMDB.Core.Providers.V4;

public sealed partial class TmdbV4Client : IAuthProvider
{
    private IAuthApi? _authApi;

    private IAuthApi AuthApi => this._authApi ??= this.CreateRefitInterface<IAuthApi>();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="createRequestTokenRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <remarks>
    /// This method generates a new request token that you can ask a user to approve. 
    /// This is the first step in getting permission from a user to read and write data on their behalf.
    /// </remarks>
    /// <returns></returns>
    public async Task<RequestToken> CreateRequestTokenAsync(CreateRequestTokenRequest createRequestTokenRequest,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(createRequestTokenRequest);
        ArgumentException.ThrowIfNullOrWhiteSpace(createRequestTokenRequest.RedirectTo);

        return await this.AuthApi.CreateRequestTokenAsync(createRequestTokenRequest, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="redirectTo"></param>
    /// <param name="cancellationToken"></param>
    /// <remarks>
    /// This method generates a new request token that you can ask a user to approve. 
    /// This is the first step in getting permission from a user to read and write data on their behalf.
    /// </remarks>
    /// <returns></returns>
    public async Task<RequestToken> CreateRequestTokenAsync(string redirectTo, 
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(redirectTo);

        CreateRequestTokenRequest createRequestTokenRequest = new(redirectTo);

        return await this.CreateRequestTokenAsync(createRequestTokenRequest, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="createAccessTokenRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <remarks>
    /// This method will finish the user authentication flow and issue an official user access token. 
    /// The request token in this request is sent along as part of the POST body. 
    /// You should still use your standard API read access token for authenticating this request.
    /// </remarks>
    /// <returns></returns>
    public async Task<AccessToken> CreateAccessTokenAsync(CreateAccessTokenRequest createAccessTokenRequest,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(createAccessTokenRequest);
        ArgumentException.ThrowIfNullOrWhiteSpace(createAccessTokenRequest.RequestToken);

        return await this.AuthApi.CreateAccessTokenAsync(createAccessTokenRequest, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="requestToken"></param>
    /// <param name="cancellationToken"></param>
    /// <remarks>
    /// This method will finish the user authentication flow and issue an official user access token. 
    /// The request token in this request is sent along as part of the POST body. 
    /// You should still use your standard API read access token for authenticating this request.
    /// </remarks>
    /// <returns></returns>
    public async Task<AccessToken> CreateAccessTokenAsync(string requestToken, 
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(requestToken);

        CreateAccessTokenRequest createAccessTokenRequest = new(requestToken);

        return await this.CreateAccessTokenAsync(createAccessTokenRequest, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>
    /// Log out of a session.
    /// </summary>
    /// <param name="logoutRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Response> LogoutAsync(LogoutRequest logoutRequest, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(logoutRequest);
        ArgumentException.ThrowIfNullOrWhiteSpace(logoutRequest.AccessToken);

        return await this.AuthApi.LogoutAsync(logoutRequest, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>
    /// Log out of a session.
    /// </summary>
    /// <param name="accessToken"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Response> LogoutAsync(string accessToken, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(accessToken);

        LogoutRequest logoutRequest = new(accessToken);

        return await this.LogoutAsync(logoutRequest, cancellationToken)
            .ConfigureAwait(false);
    }
}
