namespace CarBook.Application.Features.CQRS.Commands.AboutCommands;

public class RemoveAboutCommand
{
    public int ID { get; set; }
    public RemoveAboutCommand(int id)
    {
        ID = id;
    }
}
