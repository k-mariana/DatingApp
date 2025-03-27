using System.Security.Claims;

namespace DatingApp.API.Extensions;

public static class ClaimsPrincipleExtensions
{
    public static string GetUsername(this ClaimsPrincipal user)
    {
        var username = user.FindFirstValue(ClaimTypes.Name);
        if (username == null) throw new Exception("Cannot get username from token");
        return username;
    }

    public static Guid GetUserId(this ClaimsPrincipal user)
    {
        var userId = Guid.Parse(user.FindFirstValue(ClaimTypes.NameIdentifier)
        ?? throw new Exception("Cannot get username from token"));
        return userId;
    }
}
