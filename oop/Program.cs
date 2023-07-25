using System;

namespace OOP
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var costumer = new Costumer();
      costumer.Name = "Test";
      Console.WriteLine(costumer.Name);
    }

    class Costumer
    {
      public string? Name;
      public Costumer(string? name)
      {
        Name = name;
      }

      public Costumer()
      {

      }
    }

    class Payment
    {
      public decimal Value { get; set; }
      public DateTime Expiration { get; set; }
      public decimal Discount { get; set; }
      public decimal Fees { get; set; }
      public decimal Penalty { get; set; }

      void Pay()
      {
        ConsultCreditCardBalance();
      }

      void ConsultCreditCardBalance() { }
    }
  }
}