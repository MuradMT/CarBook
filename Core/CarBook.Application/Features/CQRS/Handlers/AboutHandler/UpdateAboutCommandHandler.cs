using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandler;

public class UpdateAboutCommandHandler(IRepository<About> _repo)
{
    public async Task Handle(UpdateAboutCommand command)
    {
        var entity=await _repo.GetByIdAsync(command.AboutID);
        entity.Description = command.Description;
        entity.ImageURL = command.ImageURL;
        entity.Tittle= command.Tittle;
        await _repo.UpdateAsync(entity);
    }
}
