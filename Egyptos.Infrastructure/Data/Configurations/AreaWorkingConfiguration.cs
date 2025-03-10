using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class AreaWorkingConfiguration : IEntityTypeConfiguration<AreaWorking>
{
    public void Configure(EntityTypeBuilder<AreaWorking> builder)
    {
        builder.HasKey(x => new { x.AreaId, x.WorkingId });
    }
}
