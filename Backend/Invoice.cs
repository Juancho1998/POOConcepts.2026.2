namespace Backend;

public class Invoice : IPay
{
    //Constructors
    public Invoice(int id, string descrioption, decimal price, float quantity)
    {
        Id = id;
        Descrioption = descrioption;
        Price = price;
        Quantity = quantity;
    }

    //Propierties

    public int Id { get; set; }
    public string Descrioption { get; set; } = null!;
    public decimal Price { get; set; }
    public float Quantity { get; set; }


    //Public Methods
    public decimal GetValueToPay() => Price * (decimal)Quantity;

    public override string ToString() => $"{Id}\t{Descrioption}\n\t" +
               $"Quantity...........: {Quantity,20:N2}\n\t" +
               $"Price..............: {Price,20:C2}\n\t" +
               $"Value..............: {GetValueToPay(),20:C2}";

}
