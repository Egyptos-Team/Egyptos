namespace Egyptos.Application.Contracts.Users;

public record ChangePasswordRequest(
    string CurrentPassword,
    string NewPassword
);
