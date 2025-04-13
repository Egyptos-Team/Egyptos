namespace Egyptos.Application.Contracts.Items;
public record ItemsResponse
(
    int Id,
    int AreaId,
    string Title,
    string Description,
    DateOnly Date,
    string ImageUrl
);
