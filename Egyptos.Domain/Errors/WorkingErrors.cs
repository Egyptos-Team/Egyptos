using Microsoft.AspNetCore.Http;

namespace Egyptos.Domain.Errors;
public class WorkingErrors
{
    public static readonly Error DuplicatedWorking = new("Working.DuplicatedWorking",
        "the same Working is already exists", StatusCodes.Status409Conflict);

    public static readonly Error WorkingNotFount = new("Working.WorkingNotFount",
        "No working type was found with the given ID", StatusCodes.Status404NotFound);

    public static readonly Error DuplicatedAreaWorking = new("AreaWorking.DuplicatedAreaWorking",
        "the same AreaWorking is already exists", StatusCodes.Status409Conflict);

    public static readonly Error AreaWorkingNotFount = new("AreaWorking.AreaWorkingNotFount",
        "No area working type was found with the given ID", StatusCodes.Status404NotFound);
}
