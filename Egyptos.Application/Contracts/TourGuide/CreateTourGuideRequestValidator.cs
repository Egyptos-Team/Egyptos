using Egyptos.Application.Contracts.EventImages;
using FluentValidation;

namespace Egyptos.Application.Contracts.TourGuide;

public class CreateTourGuideRequestValidator : AbstractValidator<CreateTourGuideRequest>
{
    public CreateTourGuideRequestValidator()
    {
        RuleFor(s => s.SalaryPerHour)
            .NotEmpty();

        RuleFor(s => s.Description)
            .NotEmpty();

        RuleFor(s => s.YearsOfExperience)
            .NotEmpty();

        RuleFor(s => s.UserId)
            .NotEmpty();
    }
}

public class UpdateTourGuideRequestValidator : AbstractValidator<UpdateTourGuideRequest>
{
    public UpdateTourGuideRequestValidator()
    {
        RuleFor(s => s.SalaryPerHour)
            .NotEmpty();

        RuleFor(s => s.Description)
            .NotEmpty();

        RuleFor(s => s.YearsOfExperience)
            .NotEmpty();

        RuleFor(s => s.Rate)
            .NotEmpty();
    }
}