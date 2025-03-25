using FluentValidation;

namespace Egyptos.Application.Contracts.AreaType;

public class AreaTypeRequestValidator : AbstractValidator<AreaTypeRequest>
{
    public AreaTypeRequestValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .Length(3,20 );
    }
}
