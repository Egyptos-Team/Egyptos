using Microsoft.AspNetCore.Http;

namespace Egyptos.Domain.Errors;

public class TourGuideErrors
{
    public static readonly Error DuplicatedUserId = new("TourGuide.DuplicatedUserId",
       "the same user id is already exists", StatusCodes.Status409Conflict);

    public static readonly Error TourGuideNotFount = new("TourGuide.TourGuideNotFount",
       "No tour guide was found with the given ID", StatusCodes.Status404NotFound);

    public static readonly Error TourGuideNotAvilable = new("TourGuide.TourGuideNotAvilable", " TourGuide is not Avilable", StatusCodes.Status404NotFound);

    public static readonly Error UserNotBooked = new("BookingTourGuide.UserNotBooked",
        "No tour guide has been booked by this user", StatusCodes.Status404NotFound);

    public static readonly Error TourGuideNotBooked = new("BookingTourGuide.TourGuideNotBooked",
        "There are no reservations for this toure guid", StatusCodes.Status404NotFound);

    public static readonly Error BookingNotFount = new("TourGuide.BookingNotFount",
        "No Booking TourGuide was found with the given UserId & TourGuideId", StatusCodes.Status404NotFound);

    public static readonly Error NotYourReservation = new("BookingTourGuide.NotYourReservation",
        "Sorry, you can only cancel your own reservations", StatusCodes.Status409Conflict);

}
