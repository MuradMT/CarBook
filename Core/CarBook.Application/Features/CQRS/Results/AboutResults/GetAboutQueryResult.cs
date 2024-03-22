namespace CarBook.Application.Features.CQRS.Results.AboutResults;

public class GetAboutQueryResult
{
    public int AboutID { get; set; }
    public string Tittle { get; set; }
    public string Description { get; set; }
    public string ImageURL { get; set; }
}
