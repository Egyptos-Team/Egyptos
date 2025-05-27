using Egyptos.Application.Contracts.EventDateContracts;

namespace Egyptos.Application.Contracts.Transport.BookingPrivateTransport;

public class BookingPrivateTransportRequestValidator:AbstractValidator<BookingPrivateTransportRequest>
{
    public BookingPrivateTransportRequestValidator()
    {        

        RuleFor(x => x.Start)
           .NotEmpty();

        RuleFor(x => x.Location)
         .NotEmpty();

        RuleFor(x => x.PrivateTransportId)
           .NotEmpty();

        RuleFor(x => x)
            .Must(HasValidDates)
            .WithName(nameof(BookingPrivateTransportRequest.End))
            .WithMessage("{PropertyName} must be grater than or equal start date");


        RuleFor(x => x)
            .Must(HasValidDates1)
            .WithName(nameof(BookingPrivateTransportRequest.Start))
            .WithMessage("{PropertyName} must be grater than or equal date time now ");
    }

    private bool HasValidDates(BookingPrivateTransportRequest request)
    {        
        return  request.Start < request.End;
    }

    private bool HasValidDates1(BookingPrivateTransportRequest request) =>
       request.Start >= DateTime.UtcNow;

}
