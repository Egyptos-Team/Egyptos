using Egyptos.Application.Contracts.EventDateContracts;
using Egyptos.Application.Contracts.EventImages;

namespace Egyptos.Application.Contracts.BookingEventDate;

public record BookingEventDateRasponse
(
    string UserId,
    EventDateResponseBooking EventDate
);

public record BookingEventDateByUserRasponse
(
    string UserId,
    IEnumerable<EventDateResponseBooking> EventDates
);

public record BookingEventDateEventBooked
(
    int EventDateId,
    IEnumerable<AuthResponse> Users
);

