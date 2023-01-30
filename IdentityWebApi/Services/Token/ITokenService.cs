using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace IdentityWebApi.Services.Token
{
    public interface ITokenService
    {
        JwtSecurityToken CreateToken(List<Claim> authClaims);
        string GenerateRefreshToken();

        ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token);
    }
}
