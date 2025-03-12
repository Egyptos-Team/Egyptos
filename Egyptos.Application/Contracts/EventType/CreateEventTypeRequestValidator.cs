using FluentValidation;

namespace Egyptos.Application.Contracts.EventType;

public class CreateEventTypeRequestValidator : AbstractValidator<CreateEventTypeRequest>
{
    public CreateEventTypeRequestValidator()
    {
        RuleFor(x => x.Name)
           .NotEmpty()
           .Length(3, 100);
    }
}