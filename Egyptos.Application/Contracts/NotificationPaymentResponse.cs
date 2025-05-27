namespace Egyptos.Application.Contracts;
public class NotificationPaymentResponse
{
    public int BookingId { get; set; }
    public string UserName { get; set; }=string.Empty;  
    public string UserEmail { get; set; }=string.Empty;  
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public double TotalPrice { get; set; }
    public DateTime? PaymentDate { get; set; }
    public string PrivateTransportName { get; set; } = string.Empty;
}
