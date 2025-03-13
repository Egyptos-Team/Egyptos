using Microsoft.AspNetCore.Http;

namespace Egyptos.Domain.Errors;

public record TransportTypeErrors
{
    public static readonly Error DoublicatedTitle
       = new ("TransportType.DoublicatedTitle", "Another TransportType with the same Name is already excist ", StatusCodes.Status409Conflict);

    public static readonly Error NotFound = new("TransportType.NotFound", "TransportType is not exists", StatusCodes.Status404NotFound);
}
