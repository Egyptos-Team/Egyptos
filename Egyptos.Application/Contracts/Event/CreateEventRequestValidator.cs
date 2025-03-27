using Egyptos.Application.Contracts.EventType;

namespace Egyptos.Application.Contracts.Event;
public class CreateEventValidator : AbstractValidator<CreateEventRequest>
{
    public CreateEventValidator()
    {
        RuleFor(x => x.Name)
           .NotEmpty()
           .Length(3, 100);

        RuleFor(x => x.Description)
            .NotEmpty()
            .Length(10, 5000);

        RuleFor(x => x.EventTypeId)
            .NotEmpty();
    }
}