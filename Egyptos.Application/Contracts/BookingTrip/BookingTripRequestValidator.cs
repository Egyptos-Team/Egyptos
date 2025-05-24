using Egyptos.Application.Contracts.BookingTourGuide;
using FluentValidation;

namespace Egyptos.Application.Contracts.BookingTrip;
internal class BookingTripRequestValidator : AbstractValidator<BookingTripRequest>
{
    public BookingTripRequestValidator()
    {

        RuleFor(x => x.TripId)
           .NotEmpty()
           .NotNull();

        RuleFor(x => x.NumberOfTickets)
           .NotEmpty();

        RuleFor(x => x)
           .Must(HasValidDates)
           .WithName(nameof(BookingTripRequest.NumberOfTickets))
           .WithMessage("{PropertyName} must be grater than or equal one "); ;
    }
    private bool HasValidDates(BookingTripRequest request)
    {
        return request.NumberOfTickets >= 1;
    }
}
