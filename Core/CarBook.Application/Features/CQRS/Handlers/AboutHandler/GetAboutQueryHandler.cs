using CarBook.Application.Features.CQRS.Results.AboutResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandler;

public class GetAboutQueryHandler(IRepository<About> _repo)
{
    public async Task<List<GetAboutQueryResult>> Handle()
    {
        var values = await _repo.GetAllAsync();
        return values.Select(x=>new GetAboutQueryResult
        {
            AboutID = x.AboutID,
            Description = x.Description,
            ImageURL = x.ImageURL,
            Tittle=x.Tittle
        }
        ).ToList();
    }

}
