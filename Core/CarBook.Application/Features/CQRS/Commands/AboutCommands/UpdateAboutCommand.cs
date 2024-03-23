namespace CarBook.Application.Features.CQRS.Commands.AboutCommands;

public class UpdateAboutCommand
{
    public int AboutID { get; set; }
    public string Tittle { get; set; }
    public string Description { get; set; }
    public string ImageURL { get; set; }
}
