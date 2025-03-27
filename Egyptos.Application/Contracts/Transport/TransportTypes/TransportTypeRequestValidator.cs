namespace Egyptos.Application.Contracts.Transport.TransportTypes;

public  class PrivateTransportValidator : AbstractValidator<TransportTypeRequest>
{
    public PrivateTransportValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty();
    }
}
