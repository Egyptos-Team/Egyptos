using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.AreaType;
using Egyptos.Application.Contracts.Transport.BookingPrivateTransport;
using Egyptos.Application.Contracts.Transport.TransportTypes;
using Egyptos.Application.Services.Implementations;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AreaTypesController(IAreaTypeService areaTypeService) : ControllerBase
    {
        private readonly IAreaTypeService _areaTypeService = areaTypeService;

        [HttpGet("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAll()
        {
            var result = await _areaTypeService.GetAllAsync();

            return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _areaTypeService.GetAsync(id);

            return result.IsSuccess
                ? Ok(result.Value)
                : result.ToProblem();
        }


        [HttpPost("")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(Roles = DefaultRoles.Admin.Name)]
        public async Task<IActionResult> Create([FromBody] AreaTypeRequest request)
        {
            var result = await _areaTypeService.CreateAsync(request);

            return result.IsSuccess
                 ? CreatedAtAction(nameof(Get), new { id = result.Value.Id }, result.Value)
                 : result.ToProblem();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(Roles = DefaultRoles.Admin.Name)]
        public async Task<IActionResult> Update( int id, [FromBody] AreaTypeRequest request)
        {
            var result = await _areaTypeService.UpdateAsync(id, request);

            return result.IsSuccess
                ? NoContent()
                : result.ToProblem();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(Roles = DefaultRoles.Admin.Name)]
        public async Task<IActionResult> Delete( int id)
        {
            var result = await _areaTypeService.DeleteAsync(id);
            return result.IsSuccess
              ? NoContent()
              : result.ToProblem();
        }
    }
}
