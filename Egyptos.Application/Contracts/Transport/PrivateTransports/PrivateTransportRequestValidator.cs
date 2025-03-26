using Egyptos.Application.Contracts.Transport.PrivateTransports;


namespace Egyptos.Application.Contracts.Transport.PrivateTransport;

public  class PrivateTransportRequestValidator : AbstractValidator<PrivateTransportRequest>
{
    public PrivateTransportRequestValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty();

        RuleFor(x => x.PricePerHour)
            .GreaterThan(0)
            .NotEmpty();

        RuleFor(x => x.Description)
            .NotEmpty();

        RuleFor(x => x.Capacity)
            .GreaterThan(0)
            .NotEmpty();

        RuleFor(x => x.Quantity)
            .GreaterThan(0)
            .NotEmpty();

        RuleFor(x => x.TransportTypeId)
            .NotEmpty();


    }
}
