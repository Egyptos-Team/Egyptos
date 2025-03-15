using Egyptos.Application.Contracts.Transport.BookingPrivateTransport;
using FluentValidation;

namespace Egyptos.Application.Contracts.BookingTourGuide;

public class BookingTourGuideRequestValidtor : AbstractValidator<BookingTourGuideRequest>
{
    public BookingTourGuideRequestValidtor()
    {

        RuleFor(x => x.StartBooking)
           .NotEmpty();

        RuleFor(x => x.EndBooking)
           .NotEmpty();

        RuleFor(x => x.TourGuideId)
           .NotEmpty();

        RuleFor(x => x)
            .Must(HasValidDates)
            .WithName(nameof(BookingTourGuideRequest.EndBooking))
            .WithMessage("{PropertyName} must be grater than or equal start date");


        RuleFor(x => x)
            .Must(HasValidDates1)
            .WithName(nameof(BookingTourGuideRequest.StartBooking))
            .WithMessage("{PropertyName} must be grater than or equal date time now ");
    }

    private bool HasValidDates(BookingTourGuideRequest request)
    {
        if (request.EndBooking == null)
            return true;
        return request.StartBooking <= request.EndBooking;
    }
    private bool HasValidDates1(BookingTourGuideRequest request) =>
       request.StartBooking >= DateTime.UtcNow;
}