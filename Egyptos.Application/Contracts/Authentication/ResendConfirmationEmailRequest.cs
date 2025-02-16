using System.ComponentModel.DataAnnotations;

namespace Egyptos.Application.Contracts.Authentication;

public record ResendConfirmationEmailRequest(
    [EmailAddress] string Email
);
