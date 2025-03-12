using FluentValidation;

namespace Egyptos.Application.Contracts.Event;

public class UpdateEventRequestValidator : AbstractValidator<UpdateEventRequest>
{
    public UpdateEventRequestValidator()
    {
        RuleFor(x => x.Name)
           .NotEmpty()
           .Length(3, 100);

        RuleFor(x => x.Description)
            .NotEmpty()
            .Length(10, 5000);
    }
}
