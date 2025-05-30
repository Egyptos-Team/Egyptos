using Egyptos.Application.Contracts.Payment;
using Microsoft.Extensions.Configuration;
using Stripe.Checkout;

namespace Egyptos.Application.Services.Implementations;

public class Payment(IConfiguration configuration) : IPayment
{

    private readonly IConfiguration _configuration = configuration;
    private static readonly string? ClientUrl = string.Empty;

    public async Task<string> ProcessPayment<T>(T booking, PaymentRequest paymentRequest) where T : class
    {
        ArgumentNullException.ThrowIfNull(booking);

        var (name, description, imageUrl, totalPrice) = GetBookingDetails(booking);

        var image = $"{paymentRequest.ApiUrl}/{imageUrl.Replace(" ", "%20")}";

        var options = new SessionCreateOptions
        {
            SuccessUrl = paymentRequest.SuccessRedirectUrl,
            CancelUrl = paymentRequest.CancelRedirectUrl,
            PaymentMethodTypes = ["card"],
            LineItems =
            [
                new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmountDecimal = (decimal)(totalPrice * 100),
                        Currency = "USD",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = name,
                            Description = description,
                            Images = [image]
                        },
                    },
                    Quantity = 1,
                }
            ],
            Mode = "payment"
        };

        var service = new SessionService();
        var session = await service.CreateAsync(options);
        return session.Id;
    }


    private (string Name, string Description, string ImageUrl, double TotalPrice) GetBookingDetails<T>(T booking)
    where T : class
    {
        return booking switch
        {
            BookingPrivateTransport b => (
                Name: b.PrivateTransport?.Name ?? "Private Transport Service",
                Description: b.PrivateTransport?.Description ?? "Private transport booking",
                ImageUrl: b.PrivateTransport?.ImageUrl ?? string.Empty,
                b.TotalPrice
            ),

            BookingHotel b => (
                Name: b.Hotel?.Name ?? "Hotel Accommodation",
                Description: b.Hotel?.Name ?? b.Hotel?.Name ?? "Hotel booking",
                ImageUrl: b.Hotel?.ImageUrl ?? string.Empty,
                b.TotalPrice
            ),

            BookingEventDate b => (
                Name: b.EventDate?.Event?.Name ?? "Event Booking",
                Description: b.EventDate?.Event?.Description ?? "Event participation",
                ImageUrl: GetSafeEventImageUrl(b.EventDate?.EventImages.Select(x => x.ImageUrl)),
                TotalPrice: b.EventDate?.Price ?? 0.0
            ),
            BookingTrip b => (
                Name: b.Trip.Area.Name ?? "Area Trip",
                Description: b.Trip.Area.Description ?? "Area trip description",
                ImageUrl: GetSafeAreaImageUrl(b.Trip.Area.AreaImages.Select(x => x.ImageUrl)),
                TotalPrice: b?.TotalPrice ?? 0

            ),
            BookingTourGuide b => (
                Name: b.TourGuide.User.FirstName +" " + b.TourGuide.User.LastName ?? "TourGuide Booking",
                Description: b.TourGuide.Description ?? "Experienced tour guide for your journey",
                ImageUrl: (b.TourGuide.User.ImageUrl) ?? "profiles\\Default-Image.jpg",
                TotalPrice: b?.TotalPrice ?? 0
            ),
            _ => throw new NotSupportedException($"Booking type '{typeof(T).Name}' is not currently supported for payment processing")
        };
    }

    private static string GetSafeEventImageUrl(IEnumerable<string>? eventImages)
    {
        return eventImages?.FirstOrDefault(img => !string.IsNullOrWhiteSpace(img)) ?? string.Empty;
    }

    private static string GetSafeAreaImageUrl(IEnumerable<string>? areaImages)
    {
        return areaImages?.FirstOrDefault(img => !string.IsNullOrWhiteSpace(img)) ?? string.Empty;
    }

}
