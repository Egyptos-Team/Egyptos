using Microsoft.AspNetCore.Http;

namespace Egyptos.Application.Contracts.EventDateContracts;
public record UpdateEventDateRequest
(
    DateTime StartDate,
    DateTime EndDate,
    DateTime StartSubscription,
    DateTime EndSubscription,
    string Description,
    string Location,
    double Price,
    List<IFormFile> Images
);
