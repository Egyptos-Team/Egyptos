namespace Egyptos.Application.Contracts.Payment;

public class PaymentRequest
{
    public string ApiUrl { get; set; }
    public string ClientUrl { get; set; }
    public string SuccessRedirectUrl { get; set; }
    public string CancelRedirectUrl { get; set; }
}
