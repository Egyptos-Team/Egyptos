using Egyptos.Application.Contracts.BookingEventDate;
using Egyptos.Application.Contracts.BookingTourGuide;
using Egyptos.Application.Contracts.Transport.BookingPrivateTransport;

namespace Egyptos.Application.Contracts.Users;

public record UserAllBookingsResponse(

      List<BookingPrivateTransportResponse> BookingPrivateTransports,
      List<BookingEventDateRasponse> BookingEventDates,
      List<BookingTourGuideResponse> BookingTourGuides

);

