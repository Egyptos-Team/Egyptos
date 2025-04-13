using Microsoft.AspNetCore.Http;

namespace Egyptos.Domain.Errors;
public class ItemsErrors
{
    public static readonly Error DuplicatedItem = new("Items.DuplicatedItem",
        "the same Item is already exists", StatusCodes.Status409Conflict);

    public static readonly Error ItemNotFount = new("Items.ItemNotFount",
        "No Item type was found with the given ID", StatusCodes.Status404NotFound);

    //public static readonly Error DuplicatedAreaWorking = new("AreaWorking.DuplicatedAreaWorking",
    //    "the same AreaWorking is already exists", StatusCodes.Status409Conflict);

    //public static readonly Error AreaWorkingNotFount = new("AreaWorking.AreaWorkingNotFount",
    //    "No area working type was found with the given ID", StatusCodes.Status404NotFound);
}
