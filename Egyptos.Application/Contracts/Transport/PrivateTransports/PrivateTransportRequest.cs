namespace Egyptos.Application.Contracts.Transport.PrivateTransports;

public record PrivateTransportRequest(
     string Name,
    double PricePerHour,
    string Description,
    IFormFile ImageUrl,
    int Capacity,
    int Quantity,
    int TransportTypeId

);
