using Microsoft.AspNetCore.Http;

namespace Egyptos.Domain.Errors;

public class HotelError
{
    public static readonly Error NotFount
        = new("HotelError.NotFount", "The hotel is not exsist", StatusCodes.Status404NotFound);
    public static readonly Error Doublicated
        = new("HotelError.Doublicated", "The hotel is already exsist", StatusCodes.Status409Conflict);
}
