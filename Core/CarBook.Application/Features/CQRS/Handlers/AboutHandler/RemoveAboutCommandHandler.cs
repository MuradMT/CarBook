using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandler;

public class RemoveAboutCommandHandler(IRepository<About> _repo)
{
    public async Task Handle(RemoveAboutCommand command)
    {
        var entity=await _repo.GetByIdAsync(command.ID);
        await _repo.RemoveAsync(entity);
    }
}
