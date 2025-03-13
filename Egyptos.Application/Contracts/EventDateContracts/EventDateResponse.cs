using Egyptos.Application.Contracts.EventImages;
using Egyptos.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace Egyptos.Application.Contracts.EventDateContracts;

public record EventDateResponse
(
    int Id,
    int EventId,
    string Description,
    string Location,
    double Price,
    DateTime StartDate,
    DateTime EndDate,
    DateTime StartSubscription,
    DateTime EndSubscription,
    bool IsActiveToSubscribe,
    IEnumerable<EventImageResponse> EventImages
);
