using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egyptos.Infrastructure.Data.Configurations;
internal class TripConfigrution : IEntityTypeConfiguration<Trip>
{
    public void Configure(EntityTypeBuilder<Trip> builder)
    {
        var Trips = new List<Trip>
        {
            new Trip
            {
                Id=1,
                DepartureTime = new DateTime(2025, 7, 10, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 7, 10, 12, 00, 00),
                BackTime = new DateTime(2025, 7, 10, 17, 00, 00),
                Price=1000,
                AreaId=1,
                PublicTransportId=1,
            },
        };
        builder.HasData(Trips);
    }
}