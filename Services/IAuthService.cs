using JwtAuthDotNet9_New.Entities;
using JwtAuthDotNet9_New.Models;

namespace JwtAuthDotNet9_New.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);
            Task<TokenresponseDto?> LoginAsync(UserDto request);  
        Task<TokenresponseDto?> RefreshTokensAsync(RefreshTokenRequestDto request);
    }
}
