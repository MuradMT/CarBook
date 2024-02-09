namespace CarBook.Domain.Entities;

public class Prising
{
    public int PrisingID { get; set; }
    public string Name { get; set; }
    public CarPrising CarPrisings { get; set; }
}
