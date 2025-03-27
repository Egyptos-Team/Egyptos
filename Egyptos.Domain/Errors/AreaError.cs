using Microsoft.AspNetCore.Http;

namespace Egyptos.Domain.Errors;

public   record AreaError
{
    public static readonly Error NotFound
        = new("Area.NotFound", "Area is not exists", StatusCodes.Status404NotFound);
    public static readonly Error DoublicatedTitle
      = new("Area.DoublicatedTitle", "Another Area has the same Name and address ", StatusCodes.Status409Conflict);

}
