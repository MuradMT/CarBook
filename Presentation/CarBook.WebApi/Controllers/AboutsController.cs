using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using CarBook.Application.Features.CQRS.Handlers.AboutHandler;
using CarBook.Application.Features.CQRS.Queries.AboutQueries;
using CarBook.Application.Features.CQRS.Results.AboutResults;
using CarBook.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController(
           GetAboutByIdQueryHandler _getAboutByIdQueryHandler,
           GetAboutQueryHandler _getAboutQueryHandler,
           CreateAboutCommandHandler _createAboutCommandHandler,
           UpdateAboutCommandHandler _updateAboutCommandHandler,
           RemoveAboutCommandHandler _removeAboutCommandHandler
        ) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> AboutList()
        {
            var values= await _getAboutQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAbout(int id)
        {
            var value= await _getAboutByIdQueryHandler.Handle(new GetAboutByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutCommand command)
        {
            await _createAboutCommandHandler.Handle(command);
            return Ok("About information added.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutCommand command)
        {
            await _updateAboutCommandHandler.Handle(command);
            return Ok("About information updated.");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveAbout(int id )
        {
            await _removeAboutCommandHandler.Handle(new RemoveAboutCommand(id));
            return Ok("About information deleted.");
        }
    }
}
