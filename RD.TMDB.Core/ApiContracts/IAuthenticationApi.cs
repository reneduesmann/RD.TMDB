using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Authentications;

namespace RD.TMDB.Core.ApiContracts;

/// <summary>
/// Interface that defines the endpoints for the authentication specifications of tmdb.
/// </summary>
public interface IAuthenticationApi
{
    /// <summary>
    /// Guest sessions are a special kind of session that give you some of the functionality of an account, but not all. For example, 
    /// some of the things you can do with a guest session are; maintain a rated list, a watchlist and a favourite list.
    /// Guest sessions will automatically be deleted if they are not used within 60 minutes of it being issued.
    /// </summary>
    /// <returns>Created guest session.</returns>
    [Get("/authentication/guest_session/new")]
    Task<GuestSession> CreateGuestSessionAsync(
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Create an intermediate request token that can be used to validate a TMDB user login.
    /// </summary>
    /// <returns>Created request token.</returns>
    [Get("/authentication/token/new")]
    Task<RequestToken> CreateRequestTokenAsync(
        CancellationToken cancellationToken = default);

    /// <summary>
    /// You can use this method to create a fully valid session ID once a user has validated the request token.
    /// </summary>
    /// <param name="createSessionRequest">Request to create a session.</param>
    /// <returns>Created session.</returns>
    [Post("/authentication/session/new")]
    Task<Session> CreateSessionAsync([Body(BodySerializationMethod.Serialized)] CreateSessionRequest createSessionRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// This method allows an application to validate a request token by entering a username and password.
    /// </summary>
    /// <param name="createSessionWithLoginRequest">Request to create a session with username and password.</param>
    /// <returns>Created session.</returns>
    [Post("/authentication/token/validate_with_login")]
    Task<SessionWithLogin> CreateSessionWithLoginRequestAsync(
        [Body(BodySerializationMethod.Serialized)] CreateSessionWithLoginRequest createSessionWithLoginRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="deleteSessionRequest">Request to delete a session.</param>
    /// <returns>Deleted session result.</returns>
    [Delete("/authentication/session")]
    Task<DeleteSession> DeleteSessionAsync([Body(BodySerializationMethod.Serialized)] DeleteSessionRequest deleteSessionRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Test your API Key to see if it's valid.
    /// </summary>
    /// <returns>Operation result.</returns>
    [Get("/authentication")]
    Task<Response> ValidateKeyAsync(
        CancellationToken cancellationToken = default);
}
