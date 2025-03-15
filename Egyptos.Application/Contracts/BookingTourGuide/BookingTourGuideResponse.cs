using Egyptos.Application.Contracts.EventDateContracts;
using Egyptos.Application.Contracts.TourGuide;

namespace Egyptos.Application.Contracts.BookingTourGuide;

public record BookingTourGuideResponse
(
     string UserId,
     int TourGuideId,
     DateTime StartBooking,
     DateTime EndBooking,
     double TotalPrice 
);

public record BookingTourGuideByUserRasponse
(
    string UserId,
    IEnumerable<TourGuideResponse> TourGuides
);

public record BookingTourGuideBooked
(
     int TourGuideId,
     DateTime StartBooking,
     DateTime EndBooking,
     double TotalPrice,
     IEnumerable<AuthResponse> Users
);

