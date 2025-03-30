using Microsoft.AspNetCore.Http;

namespace Egyptos.Domain.Errors;
public class WorkingErrors
{
    public static readonly Error DuplicatedWorking = new("Working.DuplicatedWorking",
        "the same Working is already exists", StatusCodes.Status409Conflict);

    public static readonly Error WorkingNotFount = new("Working.WorkingNotFount",
        "No working type was found with the given ID", StatusCodes.Status404NotFound);
}
