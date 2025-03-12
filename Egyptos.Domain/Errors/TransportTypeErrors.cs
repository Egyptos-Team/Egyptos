using Microsoft.AspNetCore.Http;

namespace Egyptos.Domain.Errors;

public record TransportTypeErrors
{
    public static readonly Error DoublicatedTransportTypeTitle
       = new ("TransportType.DoublicatedTitle", "Another TransportType with the same Name is already excist ", StatusCodes.Status409Conflict);
}
