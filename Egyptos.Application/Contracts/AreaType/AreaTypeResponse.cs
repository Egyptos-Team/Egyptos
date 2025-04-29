
using Egyptos.Application.Contracts.Area;

namespace Egyptos.Application.Contracts.AreaType;

public record AreaTypeResponse
(
    int Id,
    string Name,
    List<AreaResponse> Areas
);

public record ListAreaTypeResponse
(
    int Id,
    string Name
);
