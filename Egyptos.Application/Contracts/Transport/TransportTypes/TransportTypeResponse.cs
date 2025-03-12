using Egyptos.Application.Contracts.Transport.PrivateTransports;

namespace Egyptos.Application.Contracts.Transport.TransportTypes;

public record TransportTypeResponse(
    int Id,
    string Name,
    IEnumerable<PrivateTransportResponse> Transports
);
