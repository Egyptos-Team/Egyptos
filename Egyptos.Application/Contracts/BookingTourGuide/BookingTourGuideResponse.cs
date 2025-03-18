using Egyptos.Application.Contracts.EventDateContracts;
using Egyptos.Application.Contracts.TourGuide;

namespace Egyptos.Application.Contracts.BookingTourGuide;
public class BookingTourGuideResponse
{
    public int Id { get; set; }    
    public int TourGuideId { get; set; }
    public string TourGuideFirstName { get; set; }
    public string TourGuideLastName { get; set; }
    public string UserId { get; set; } 

    public double TotalPrice { get; set; }

    public DateTime? PaymentDate { get; set; }
    public DateTime? PaymentCancel { get; set; }
    public DateTime? CancelBooking { get; set; }


    public DateTime StartBooking { get; set; } = DateTime.UtcNow;
    public DateTime EndBooking { get; set; }
}
