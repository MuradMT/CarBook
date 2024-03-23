namespace CarBook.Application.Features.CQRS.Commands.AboutCommands;

public class CreateAboutCommand
{
    public string Tittle { get; set; }
    public string Description { get; set; }
    public string ImageURL { get; set; }
}
