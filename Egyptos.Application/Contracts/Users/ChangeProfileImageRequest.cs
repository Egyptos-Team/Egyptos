using Microsoft.AspNetCore.Http;

namespace Egyptos.Application.Contracts.Users;

public class ChangeProfileImageRequest
{
    public IFormFile Image { get; set; } = null!;
}
