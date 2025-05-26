using Microsoft.AspNetCore.Http;

namespace Egyptos.Domain.Errors;
public class BookingTripErrors
{
    public static readonly Error TripNotFount = new("BookingTrip.TripNotFount",
        "No trip was found with the given ID", StatusCodes.Status404NotFound);

    public static readonly Error BookingNotFount = new("BookingTrip.BookingNotFount",
    "No Booking trip was found with the given Id", StatusCodes.Status404NotFound);

    public static readonly Error UserNotBooked = new("BookingTrip.UserNotBooked",
        "No trip has been booked by this user", StatusCodes.Status404NotFound);

    public static readonly Error TripNotBooked = new("BookingTrip.TripNotBooked",
        "There are no reservations for this trip", StatusCodes.Status404NotFound);

    public static readonly Error NotEnoughSeatsAvailable = new("BookingTrip.NotEnoughSeatsAvailable",
    "You have requested more tickets than available for this trip.",StatusCodes.Status400BadRequest);

}
