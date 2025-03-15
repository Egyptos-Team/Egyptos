using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Egyptos.Domain.Entities;

namespace Egyptos.Infrastructure.Data.Configurations;

public class TourGuideConfiguration : IEntityTypeConfiguration<TourGuide>
{
    public void Configure(EntityTypeBuilder<TourGuide> builder)
    { 
        //builder.HasData
        //(
        //    new TourGuide
        //    {
        //        Id = 1,
        //        SalaryPerHour = 3000,
        //        Description = "Description",
        //        YearsOfExperience = 3,
        //        Rate = 0 ,
        //        IsAvailable = true,
        //        IsActive = true, 
        //        UserId = "Guid",
        //    },
        //    new TourGuide
        //    {
        //        Id = 2,
        //        SalaryPerHour = 4000,
        //        Description = "Description",
        //        YearsOfExperience = 4,
        //        Rate = 0,
        //        IsAvailable = true,
        //        IsActive = true,
        //        UserId = "Guid",
        //    }
        //);
    }
}