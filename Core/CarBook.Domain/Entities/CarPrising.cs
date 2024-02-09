namespace CarBook.Domain.Entities;

public class CarPrising
{
    public int CarPrisingID { get; set; }
    public int CarID { get; set; }
    public Car Car { get; set; }
    public int PrisingID { get; set; }
    public Prising Prising { get; set; }
    public decimal Amount { get; set; }

}
