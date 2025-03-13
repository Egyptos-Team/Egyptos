namespace Egyptos.Application.Contracts.Transport.BookingPrivateTransport;

public record BookingPrivateTransportRequest(
    
     DateTime Start,
     DateTime? End,
     int PrivateTransportId
);