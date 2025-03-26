using Egyptos.Application.Contracts.Transport.BookingPrivateTransport;
using Egyptos.Application.Contracts.EventDateContracts;
using Egyptos.Application.Contracts.EventImages;
using Egyptos.Application.Contracts.Users;
using Egyptos.Application.Contracts.BookingTourGuide;
using Egyptos.Application.Contracts.TourGuideReviews;

namespace Egyptos.Application.Mapping;

public class MappingProfile : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, ApplicationUser>()
            .Map(des => des.UserName, src => src.Email)
            .Map(des => des.ImageUrl, src => "Profiles/Default-Image.jpg");

        config.NewConfig<CreateUserRequest, ApplicationUser>()
            .Map(des => des.UserName, src => src.Email)
            .Map(des => des.ImageUrl, src => "Profiles/Default-Image.jpg");

        config.NewConfig<UpdateEventDateRequest, EventDate>()
           .Ignore(dest => dest.EventImages);

        config.NewConfig<CreateEventImageRequest, EventImage>()
           .Ignore(dest => dest.ImageUrl);

        config.NewConfig<CreateEventDateRequest, EventDate>()
           .Ignore(dest => dest.EventImages);

        config.NewConfig<BookingPrivateTransport, BookingPrivateTransportResponse>()
            .Map(des => des.PricePerHour, src => src.PrivateTransport.PricePerHour);

        config.NewConfig<BookingPrivateTransport, PrivateTransport>()
           .Ignore(dest => dest.Id);

        config.NewConfig<BookingTourGuide, BookingTourGuideResponse>()
           .Map(des => des.TourGuideFirstName, src => src.TourGuide.User.FirstName)
           .Map(des => des.TourGuideLastName, src => src.TourGuide.User.LastName);

        config.NewConfig<TourGuideReview, TourGuideReviewResponse>()
            .Map(des => des.UserName, src => src.User.FirstName + " " + src.User.LastName)
            .Map(des => des.TourName, src => src.TourGuide.User.FirstName + " " + src.TourGuide.User.LastName);



    }
}
