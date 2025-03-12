using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.Transport.TransportTypes;
using Egyptos.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace Egyptos.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TransportTypeController(ITransportTypeService transportTypeService) : ControllerBase
{
    private readonly ITransportTypeService _transportTypeService = transportTypeService;

    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute]int id,CancellationToken cancellationToken)
    {
        return Ok();
    }

    [HttpPost("")]
    public async Task<IActionResult> Create([FromBody] TransportTypeRequest request
        ,CancellationToken cancellationToken)
    {
        var result = await _transportTypeService.CreateAsync(request,cancellationToken);

        return result.IsSuccess
            ? CreatedAtAction(nameof(Get), new { id=result.Value?.Id}, result.Value)
            : result.ToProblem();
    }
}
