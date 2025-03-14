using Microsoft.AspNetCore.Http;

namespace Egyptos.Domain.Errors.PrivateTransport;

public record BookingPrivateTransportError
{
    public static readonly Error DoublicatedTitle
     = new(" BookingPrivateTransport.DoublicatedTitle"
         , "Another  BookingPrivateTransport with the same Name is already excist "
         , StatusCodes.Status409Conflict);

    public static readonly Error NotFound
        = new(" BookingPrivateTransport.NotFound"
            , " BookingPrivateTransport is not exists"
            , StatusCodes.Status404NotFound);
}
