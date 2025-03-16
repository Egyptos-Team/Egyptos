using Egyptos.Application.Contracts.Transport.TransportTypes;

namespace Egyptos.Application.Contracts.Transport.PrivateTransports;

public record PrivateTransportResponse(
    int Id,
    string Name,
    double PricePerHour,
    string Description,
    string? ImageUrl,
    int Capacity,
    int Quantity,
    bool IsAvailable,
    TransportTypeResponse TransportType

);

public record PrivateTransportWithoutTypeResponse(
    int Id,
    string Name,
    double PricePerHour,
    string Description,
    string? ImageUrl,
    int Capacity,
    int Quantity,
    bool IsAvailable
);
