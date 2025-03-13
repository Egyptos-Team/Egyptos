using Egyptos.Application.Contracts.EventDateContracts;
using Egyptos.Application.Contracts.EventImages;
using Egyptos.Application.Contracts.Users;
using Egyptos.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Diagnostics;

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
    }
}
