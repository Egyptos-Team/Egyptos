using Microsoft.AspNetCore.Http;

namespace Egyptos.Application.Contracts.Authentication;


public record RegisterRequest(
    string FirstName,
    string LastName,
    string Email,
    string NationalId,
    int NationalityId,
    string PhoneNumber,
    string Sex,
    string Password,
    string ConfirmPassword
);
