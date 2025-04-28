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
                    UnitAmountDecimal = (decimal)totalPrice!,
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
            BookingPrivateTransport b => (b.PrivateTransport.Name, b.PrivateTransport.Description, b.PrivateTransport.ImageUrl, b.TotalPrice.Value),
            BookingHotel b => (b.Hotel.Name, b.Hotel.Name, b.Hotel.ImageUrl, b.TotalPrice),
            BookingEventDate b => (b.EventDate.Event.Name, b.EventDate.Event.Description, b.EventDate.EventImages.First(),
                b.EventDate.Price),
            _ => throw new InvalidOperationException("Unsupported booking type")
        };
    }
}
