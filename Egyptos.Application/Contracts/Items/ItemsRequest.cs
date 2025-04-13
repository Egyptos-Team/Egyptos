namespace Egyptos.Application.Contracts.Items;
public record ItemsRequest
(
    string Title,
    string Description,
    DateOnly Date,
    IFormFile Image
);
