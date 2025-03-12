using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egyptos.Application.Contracts.Transport.PrivateTransports
{
    public record PrivateTransportResponse(
        int Id,
        string Name,
        double PricePerHour,
        string Description,
        string? ImageUrl,
        int Capacity,
        int Quantity
    );
}
