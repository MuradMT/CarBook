namespace CarBook.Application.Features.CQRS.Queries.AboutQueries;

public class GetAboutByIdQuery
{
    public int ID { get; set; }
    public GetAboutByIdQuery(int id)
    {
        ID = id;
    }
}
