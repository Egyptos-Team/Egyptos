using Egyptos.Application.Contracts.Payment;

namespace Egyptos.Application.Services.Interfaces;

public interface IPayment
{
    Task<string> ProcessPayment<T>(T booking, PaymentRequest paymentRequest) where T : class;
}
