using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Egyptos.Api.Extensions;

public static class UserExtensions
{
    public static string GetUserId(this ClaimsPrincipal claims) =>
        claims.FindFirstValue(ClaimTypes.NameIdentifier)!;


    public static string? GetUserIdFromToken(this string token)
    {
        var handler = new JwtSecurityTokenHandler();

        try
        {
            var jwtToken = handler.ReadJwtToken(token);
            var userId = jwtToken.Claims.FirstOrDefault(c => c.Type == "sub")?.Value;
            return userId;
        }
        catch
        {
            // Token is malformed or unreadable
            return null;
        }
    }
}
