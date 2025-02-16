using System.ComponentModel.DataAnnotations;

namespace Egyptos.Application.Contracts.Authentication;

public record ForgetPasswordRequest(
    [EmailAddress] string Email
);
