using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Authentications;

namespace RD.TMDB.Core.Contracts;

public interface IAuthenticationProvider
{
    Task<GuestSession> CreateGuestSessionAsync(CancellationToken cancellationToken = default);
    
    Task<RequestToken> CreateRequestTokenAsync(CancellationToken cancellationToken = default);
    
    Task<Session> CreateSessionAsync(CreateSessionRequest createSessionRequest, CancellationToken cancellationToken = default);
    
    Task<Session> CreateSessionAsync(string requestToken, CancellationToken cancellationToken = default);
    
    Task<SessionWithLogin> CreateSessionWithLoginRequestAsync(CreateSessionWithLoginRequest createSessionWithLoginRequest, CancellationToken cancellationToken = default);
    
    Task<SessionWithLogin> CreateSessionWithLoginRequestAsync(string username, string password, string requestToken, CancellationToken cancellationToken = default);
    
    Task<DeleteSession> DeleteSessionAsync(DeleteSessionRequest deleteSessionRequest, CancellationToken cancellationToken = default);
    
    Task<DeleteSession> DeleteSessionAsync(string sessionId, CancellationToken cancellationToken = default);
    
    Task<Response> ValidateKeyAsync(CancellationToken cancellationToken = default);
}