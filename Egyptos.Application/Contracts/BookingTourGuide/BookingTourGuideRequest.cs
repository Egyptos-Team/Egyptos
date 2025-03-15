namespace Egyptos.Application.Contracts.BookingTourGuide;

public record BookingTourGuideRequest
(
     DateTime StartBooking,
     DateTime EndBooking,
     int TourGuideId
);
