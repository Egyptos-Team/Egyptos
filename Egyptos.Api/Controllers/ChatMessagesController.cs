using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.ChatMessage;
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
    public class ChatMessagesController(IChatMessageService chatMessageService) : ControllerBase
    {
        private readonly IChatMessageService _chatMessageService = chatMessageService;

        [HttpGet("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var result = await _chatMessageService.GetAllAsync();

            return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _chatMessageService.GetAsync(id);

            return result.IsSuccess
                ? Ok(result.Value)
                : result.ToProblem();
        }
        [HttpPost("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Create([FromBody]ChatMessageRequest question)
        {
            var result = await _chatMessageService.CreateAsync(question);

            return result.IsSuccess
                 ? Ok(result.Value)
                 : result.ToProblem();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
       // [Authorize(Roles = DefaultRoles.Admin.Name)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _chatMessageService.DeleteAsync(id);

            return result.IsSuccess ? NoContent() : result.ToProblem();
        }








       
    }
}
