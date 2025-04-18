using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class AreaWorkingConfiguration : IEntityTypeConfiguration<AreaWorking>
{
    public void Configure(EntityTypeBuilder<AreaWorking> builder)
    {
        builder.HasKey(x => new { x.AreaId, x.WorkingId });

        var areaWorkings = new List<AreaWorking>();

        //1 : 30
        //71 : 78
        for (int areaId = 1; areaId <= 30; areaId++)
        {
            for (int workingId = 1; workingId <= 7; workingId++)
            {
                areaWorkings.Add(new AreaWorking
                {
                    AreaId = areaId,
                    WorkingId = workingId
                });
            }
        }

        for (int areaId = 71; areaId <= 78; areaId++)
        {
            for (int workingId = 1; workingId <= 7; workingId++)
            {
                areaWorkings.Add(new AreaWorking
                {
                    AreaId = areaId,
                    WorkingId = workingId
                });
            }
        }
        builder.HasData(areaWorkings);
    }
}
