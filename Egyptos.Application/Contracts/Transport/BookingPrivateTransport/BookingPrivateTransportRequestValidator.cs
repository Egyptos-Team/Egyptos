using Egyptos.Application.Contracts.EventDateContracts;
using FluentValidation;

namespace Egyptos.Application.Contracts.Transport.BookingPrivateTransport;

public class BookingPrivateTransportRequestValidator:AbstractValidator<BookingPrivateTransportRequest>
{
    public BookingPrivateTransportRequestValidator()
    {
        RuleFor(x => x.End)
            .NotEmpty();

        RuleFor(x => x.Start)
           .NotEmpty();

        RuleFor(x => x.PrivateTransportId)
           .NotEmpty();

        RuleFor(x=>x)
            .Must(HasValidDates)
            .WithName(nameof(BookingPrivateTransportRequest.End))
            .WithMessage("{PropertyName} must be grater than or equal start date");
    }
    private bool HasValidDates(BookingPrivateTransportRequest request) =>
       request.Start < request.End;
}
