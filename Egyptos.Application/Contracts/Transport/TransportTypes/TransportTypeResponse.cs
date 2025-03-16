using Egyptos.Application.Contracts.Transport.PrivateTransports;

namespace Egyptos.Application.Contracts.Transport.TransportTypes;

public record TransportTypeResponse(
    int Id,
    string Name
);

public record TransportTypeResponseWithTransports(
    int Id,
    string Name,
    List<PrivateTransportWithoutTypeResponse> PrivateTransports
);
