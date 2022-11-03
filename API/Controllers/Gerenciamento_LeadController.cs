using Application.Commands;
using Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Gerenciamento_LeadController : ControllerBase
    {
        private IMediator _mediator;
        public Gerenciamento_LeadController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateGerenciamento_LeadCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllGerenciamento_LeadQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _mediator.Send(new GetGerenciamento_LeadByIdQuery { Id = id });

            if (result == null)
                return NotFound();
            else 
                return Ok(result);
        }

        [HttpGet("{accepted}")]
        public async Task<IActionResult> GetByAccepted(char accepted)
        {
            var result = await _mediator.Send(new GetGerenciamento_LeadByAccepted { Accepted = accepted });

            if (result == null)
                return NotFound();
            else
                return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _mediator.Send(new DeleteGerenciamento_LeadByIdCommand { Id = id });
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, UpdateGerenciamento_LeadCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            var result = await _mediator.Send(command);

            return Ok(result);

        }

        [HttpPut("{id}/{accepted}")]
        public async Task<IActionResult> UpdateAccepted(Guid id, char accepted, UpdateGerenciamento_LeadAcceptedCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            command.Accepted = accepted;
            var result = await _mediator.Send(command);

            return Ok(result);

        }

    }
}
