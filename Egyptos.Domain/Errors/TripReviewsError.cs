using Microsoft.AspNetCore.Http;

namespace Egyptos.Domain.Errors;
public class TripReviewsError
{
    public static readonly Error NotFount = new("TripReview.NotFount",
      "No TripReview was found with the given ID", StatusCodes.Status404NotFound);

    public static readonly Error TripNotFount = new("Trip.NotFount",
      "No Trip was found with the given ID", StatusCodes.Status404NotFound);
}
