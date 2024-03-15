namespace CarBook.Domain.Entities;

public class Pricing
{
    public int PrisingID { get; set; }
    public string Name { get; set; }
    public CarPricing CarPrisings { get; set; }
}
