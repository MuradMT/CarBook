using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandler;

public class CreateAboutCommandHandler(IRepository<About> _repo)
{
    public async Task Handle(CreateAboutCommand command)
    {

        await _repo.CreateAsync(
            new About
            {
                Description = command.Description,
                ImageURL = command.ImageURL,
                Tittle = command.Tittle,
            }
            );
    }
}
