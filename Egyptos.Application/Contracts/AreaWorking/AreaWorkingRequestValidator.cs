using Egyptos.Application.Contracts.AreaType;

namespace Egyptos.Application.Contracts.AreaWorking;
public class AreaWorkingRequestValidator : AbstractValidator<AreaWorkingRequest>
{
    public AreaWorkingRequestValidator()
    {
        RuleFor(x => x.AreaId)
            .NotNull();

        RuleFor(x => x.WorkingId)
            .NotNull();
    }
}