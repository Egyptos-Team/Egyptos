using Egyptos.Application.Contracts.Transport.BookingPrivateTransport;
using Egyptos.Application.Contracts.Users;
using Egyptos.Domain.Entities;

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

        config.NewConfig<BookingPrivateTransport, BookingPrivateTransportResponse>()
            .Map(des => des.PricePerHour, src => src.PrivateTransport.PricePerHour);
    }
}
