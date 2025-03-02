namespace Egyptos.Application.Contracts.Users;

public record UserProfileResponse(
    string FirstName,
    string LastName,
    string Sex,
    string Email,
    string PhoneNumber,
    string NationalId,
    string ImageUrl,
    string UserName
);
