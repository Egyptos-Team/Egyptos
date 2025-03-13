using FluentValidation;


namespace Egyptos.Application.Contracts.Transport.TransportTypes;

public  class TransportTypeRequestValidator : AbstractValidator<TransportTypeRequest>
{
    public TransportTypeRequestValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty();
    }
}
