using System.Security.Claims;

namespace Egyptos.Api.Extensions;

public static class UserExtensions
{
    public static string GetUserId(this ClaimsPrincipal claims) =>
        claims.FindFirstValue(ClaimTypes.NameIdentifier)!;
}
