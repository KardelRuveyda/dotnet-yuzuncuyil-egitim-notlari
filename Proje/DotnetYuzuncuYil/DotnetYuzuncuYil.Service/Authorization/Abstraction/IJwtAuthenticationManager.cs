using DotnetYuzuncuYil.Core.DTOs;

namespace DotnetYuzuncuYil.Service.Abstraction
{
    public interface IJwtAuthenticationManager
    {
        AuthResponseDto Authenticate(string userName, string password);
        int? ValidateJwtToken(string token);
    }
}
