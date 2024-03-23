using CarBook.Application.Features.CQRS.Queries.AboutQueries;
using CarBook.Application.Features.CQRS.Results.AboutResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandler;

public class GetAboutByIdQueryHandler(IRepository<About> _repo)
{
    public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery query)
    {
        var value= await _repo.GetByIdAsync(query.ID);
        return new GetAboutByIdQueryResult
        {
            AboutID=value.AboutID,
            Tittle=value.Tittle,
            Description=value.Description,
            ImageURL=value.ImageURL
        };

    }
}
