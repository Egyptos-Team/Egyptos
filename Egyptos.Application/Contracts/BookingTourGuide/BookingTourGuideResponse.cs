using Egyptos.Application.Contracts.EventDateContracts;
using Egyptos.Application.Contracts.TourGuide;

namespace Egyptos.Application.Contracts.BookingTourGuide;

public record BookingTourGuideWithOutUserResponse
(
     int Id,
     string UserId,
     int TourGuideId,
     string Email,
     DateTime StartBooking,
     DateTime EndBooking,
     double TotalPrice 
);

public record BookingTourGuideResponse
(
     int Id,
     DateTime StartBooking,
     DateTime EndBooking,
     double TotalPrice,
     AuthWhithOutTokenAndExpiresInResponse User
);

public record BookingTourGuideWithoutUserIdResponse
(
     int BookingId,
     int TourGuideId,
     string FirstName,
     string LastName,
     DateTime StartBooking,
     DateTime EndBooking,
     double TotalPrice
);

public record BookingTourGuideByUserRasponse
(
     string UserId,
     IEnumerable<BookingTourGuideWithoutUserIdResponse> AllBookeingForThisUser
);

public record BookingTourGuideBookedRasponse
(
     int TourGuideId,
     IEnumerable<BookingTourGuideResponse> BookingUsers
);

