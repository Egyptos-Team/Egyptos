using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
//[Authorize(Roles = DefaultRoles.Admin.Name)]
public class BookingTourGuideController : ControllerBase
{
    //[HttpPost("")]
    //p ublic async Task<IActionResult> Add([FromBody] CreateEventRequest request)
    //{
    //    var result = await _eventService.AddAsync(request);

    //    return result.IsSuccess ? CreatedAtAction(nameof(Get), new { id = result.Value?.Id }, result.Value)
    //                            : result.ToProblem();
    //}

    //[HttpGet("")]
    //public async Task<IActionResult> GetAll()
    //{
    //    var result = await _eventService.GetAllAsync();

    //    return Ok(result);
    //}

    //[HttpGet("{id}")]
    //public async Task<IActionResult> Get([FromRoute] int id)
    //{
    //    var result = await _eventService.GetAsync(id);

    //    return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    //}

    //[Authorize(Roles = DefaultRoles.Admin.Name)]
    //[HttpPut("{id}")]
    //public async Task<IActionResult> Update([FromRoute] int id, UpdateEventRequest request)
    //{
    //    var result = await _eventService.UpdateAsync(id, request);

    //    return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    //}

    //[Authorize(Roles = DefaultRoles.Admin.Name)]
    //[HttpDelete("{id}")]
    //public async Task<IActionResult> Delete([FromRoute] int id)
    //{
    //    var result = await _eventService.DeleteAsync(id);

    //    return result.IsSuccess ? Ok() : result.ToProblem();
    //}

}
