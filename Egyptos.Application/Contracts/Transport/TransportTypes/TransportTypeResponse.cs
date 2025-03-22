using Egyptos.Application.Contracts.Transport.PrivateTransports;

namespace Egyptos.Application.Contracts.Transport.TransportTypes;

public record TransportTypeResponse(
    int Id,
    string Name,
    string? ImageUrl
);

public record TransportTypeResponseWithTransports(
    int Id,
    string Name,
    string? ImageUrl,
    List<PrivateTransportWithoutTypeResponse> PrivateTransports
);
