using Microsoft.AspNetCore.Http;

namespace Egyptos.Domain.Errors;

public class HistoricalErrors
{
    public static readonly Error HistoricalNotFount = new("Historical.HistoricalNotFount",
       "No Historical was found with the given ID", StatusCodes.Status404NotFound);
}
