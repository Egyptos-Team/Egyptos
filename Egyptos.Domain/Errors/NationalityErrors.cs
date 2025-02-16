using Microsoft.AspNetCore.Http;

namespace Egyptos.Domain.Errors;

public class NationalityErrors
{
    public static readonly Error NotFound = new("Nationality.NotFound", "Nationality is not exists", StatusCodes.Status404NotFound);
    public static readonly Error AlreadyExists  = new("Nationality.AlreadyExists", "Nationality is already exists", StatusCodes.Status409Conflict);
}
