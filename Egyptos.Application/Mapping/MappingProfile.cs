namespace Egyptos.Application.Mapping;

public class MappingProfile : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, ApplicationUser>()
            .Map(des => des.UserName, src => src.Email)
            .Map(des => des.ImageUrl, "Profiles/Default-Image.jpg");
    }
}
