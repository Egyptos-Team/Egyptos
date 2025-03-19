using Microsoft.AspNetCore.Http;

namespace Egyptos.Domain.Errors;

public class TourGuideReviewErrors
{
    public static readonly Error TourGuideReviewNotFount = new("TourGuideReview.TourGuideReviewNotFount",
        "No TourGuideReview was found with the given ID", StatusCodes.Status404NotFound);
}
