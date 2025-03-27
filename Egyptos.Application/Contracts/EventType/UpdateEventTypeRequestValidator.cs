namespace Egyptos.Application.Contracts.EventType;

public class UpdateEventTypeRequestValidator : AbstractValidator<UpdateEventTypeRequest>
{
    public UpdateEventTypeRequestValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty();
    }
}
