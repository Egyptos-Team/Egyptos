using Microsoft.AspNetCore.Http;

namespace Egyptos.Domain.Errors;

public record AreaTypeError
{
    public static readonly Error DoublicatedTitle
      = new("AreaType.DoublicatedTitle", "Another AreaType with the same Name is already excist ", StatusCodes.Status409Conflict);

    public static readonly Error NotFound
        = new("AreaType.NotFound", "AreaType is not exists", StatusCodes.Status404NotFound);

}
