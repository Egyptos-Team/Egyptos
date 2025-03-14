using Microsoft.AspNetCore.Http;

namespace Egyptos.Domain.Errors;

public class EventErrors
{
    public static readonly Error DuplicatedTypeName = new("Event.DuplicatedTypeName", 
        "the same type name is already exists", StatusCodes.Status409Conflict);

    public static readonly Error EventTypeNotFount = new("Event.EventTypeNotFount",
        "No event type was found with the given ID", StatusCodes.Status404NotFound);

    public static readonly Error DuplicatedEventName = new("Event.DuplicatedEventName",
        "the same event name is already exists", StatusCodes.Status409Conflict);

    public static readonly Error EventNotFount = new("Event.EventNotFount",
        "No event was found with the given ID", StatusCodes.Status404NotFound);

    public static readonly Error EventDateNotFount = new("Event.EventDateNotFount",
        "No event date was found with the given ID", StatusCodes.Status404NotFound);

    public static readonly Error EventImageNotFount = new("Event.EventImageNotFount",
        "No event image was found with the given ID", StatusCodes.Status404NotFound);

    public static readonly Error UserNotBooked = new("BookingEvent.UserNotBooked",
        "No event has been booked by this user", StatusCodes.Status404NotFound);

    public static readonly Error EventNotBooked = new("BookingEvent.EventNotBooked",
        "There are no reservations for this event", StatusCodes.Status404NotFound);

    public static readonly Error BookingNotFount = new("BookingEvent.BookingNotFount",
        "No Booking date was found with the given UserId & EventId", StatusCodes.Status404NotFound);
}
