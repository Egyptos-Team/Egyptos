using Microsoft.AspNetCore.Http;


namespace Egyptos.Domain.Errors.PrivateTransport;

public record PrivateTransportError
{
    public static readonly Error DoublicatedTitle
  = new(" PrivateTransport.DoublicatedTitle", "Another  PrivateTransport with the same Name is already excist ", StatusCodes.Status409Conflict);

    public static readonly Error NotFound = new(" PrivateTransport.NotFound", " PrivateTransport is not exists", StatusCodes.Status404NotFound);

    public static readonly Error NotAvilable = new(" PrivateTransport.NotAvilable", " PrivateTransport is not Avilable", StatusCodes.Status404NotFound);
}
