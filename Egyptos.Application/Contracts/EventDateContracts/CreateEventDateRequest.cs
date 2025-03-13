using Microsoft.AspNetCore.Http;

namespace Egyptos.Application.Contracts.EventDateContracts;

public record CreateEventDateRequest
(

    DateTime StartDate,
    DateTime EndDate,
    DateTime StartSubscription,
    DateTime EndSubscription,
    string Description,
    string Location,
    double Price,
    int EventId,
    List<IFormFile> Images
);
