using Microsoft.AspNetCore.Http;

namespace Egyptos.Domain.Errors;

public class PaymentError
{
    public static readonly Error NotFound 
        = new("Payment.NotFound", "PaymentDate is not exists", StatusCodes.Status404NotFound);

    public static readonly Error MustPayment
        = new("Payment.MustPayment", "please must payment first", StatusCodes.Status400BadRequest);

    public static readonly Error AlreadyPeyment 
        = new ("Peyment.AlreadyPeyment", "cannot payment booking already peyment", StatusCodes.Status409Conflict);
    public static readonly Error AlreadyCancel
       = new("Peyment.AlreadyCancel", "cannot cancel payment aleady canceld", StatusCodes.Status409Conflict);

    public static readonly Error InvalidOnlinePayment
       = new("Booking.InvalidOnlinePayment", "cannot use payment online for this booking", StatusCodes.Status400BadRequest);
}
