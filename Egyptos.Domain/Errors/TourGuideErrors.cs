using Microsoft.AspNetCore.Http;

namespace Egyptos.Domain.Errors;

public class TourGuideErrors
{
    public static readonly Error DuplicatedUserId = new("TourGuide.DuplicatedUserId",
       "the same user id is already exists", StatusCodes.Status409Conflict);

    public static readonly Error TourGuideNotFount = new("TourGuide.TourGuideNotFount",
       "No tour guide was found with the given ID", StatusCodes.Status404NotFound);

}
