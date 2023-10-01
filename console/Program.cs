// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

abstract class Payment
{
    public int Id { get; set; }
    public decimal Value { get; set; }
    public DateTime Expiration { get; set; }
    public DateTime DiscountExpiration { get; set; }
    public DateTime Payday { get; set; }
    public bool Paid { get; set; }
    public virtual bool PaymentMethod()
    {
        if (Paid) return true;
        return false;
    }
}