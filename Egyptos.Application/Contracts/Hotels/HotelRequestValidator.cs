using FluentValidation;

namespace Egyptos.Application.Contracts.Hotels;

public class HotelRequestValidator:AbstractValidator<HotelRequest>
{
    public HotelRequestValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .Length(3, 30);

        RuleFor(x => x.Location)
            .NotEmpty();

        RuleFor(x => x.Address)
           .NotEmpty();

        RuleFor(x => x.WebSite)
           .NotEmpty();

        RuleFor(x => x.Facebook)
           .NotEmpty();

        RuleFor(s => s.PhoneNumber)
            .Matches(@"^(010|011|012|015)")
            .WithMessage("Invalid phone number, must start with 010, 011, 012, or 015.")
            .Length(11).WithMessage("Invalid phone number, must end with 11 numbers.");

        RuleFor(x => x.PricePerHour)
           .NotEmpty()
           .GreaterThan(0);
    }
}
