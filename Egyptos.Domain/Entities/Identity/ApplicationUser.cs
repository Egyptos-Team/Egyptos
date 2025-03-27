using Microsoft.AspNetCore.Identity;

namespace Egyptos.Domain.Entities.Identity;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Sex { get; set; } = null!;
    public string? NationalId { get; set; }
    public string ImageUrl { get; set; } = null!;

    public ICollection<BookingTrip> BookingTrips { get; set; } = [];
    public ICollection<BookingHotel> BookingHotels { get; set; } = [];
    public ICollection<BookingEventDate> BookingEventDates { get; set; } = [];
    public ICollection<BookingPrivateTransport> BookingPrivateTransports { get; set; } = [];
    public ICollection<Report> Reports { get; set; } = [];
    public ICollection<BookingTourGuide> BookingTourGuides { get; set; } = [];
    public ICollection<TourGuideReview> TourGuideReviews { get; set; } = [];
    public ICollection<PrivateTransportReview> PrivateTransportReviews { get; set; } = [];
}
