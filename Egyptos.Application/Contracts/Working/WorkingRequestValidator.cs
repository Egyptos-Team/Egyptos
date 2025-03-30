namespace Egyptos.Application.Contracts.Working;
public class WorkingRequestValidator : AbstractValidator<WorkingRequest>
{
    public WorkingRequestValidator()
    {
        RuleFor(x => x.Day)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.StartTime)
            .NotNull();
        
        RuleFor(x => x.EndTime)
            .NotNull();
    }
}
