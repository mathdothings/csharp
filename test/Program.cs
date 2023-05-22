// See https://aka.ms/new-console-template for more information

namespace MyApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      // Product mouse = new Product();
      // mouse.Id = 0;
      // mouse.Name = "Mouse Gamer Log";
      // mouse.Price = 120.00f;
      // Console.WriteLine(mouse.Id);
      // Console.WriteLine(mouse.Name);
      // Console.WriteLine(mouse.Price);
      // Console.WriteLine(mouse.PrinceInDolar(5.25f));

      var keyboard = new Product(1, "Keyboard Log", 100.00f, EProductType.Product);
      // Console.WriteLine(keyboard.ShowInfo());

      var course = new Product(2, "C# Fundamentals", 50.00f, EProductType.Service);
      Console.WriteLine(course.ShowInfo());
    }
  }

  struct Product
  {
    public int Id;
    public string Name;
    public float Price;
    public EProductType Type;

    public Product(int id, string name, float price, EProductType type)
    {
      Id = id;
      Name = name;
      Price = price;
      Type = type;
    }

    public float PriceInReals(float dolar)
    {
      return Price * dolar;
    }

    public string ShowInfo()
    {
      return $"ID: {this.Id}\n" +
             $"Name: {this.Name}\n" +
             $"Type: {this.Type}\n" +
             $"Type: {Convert.ToInt32(this.Type)}\n" +
             $"Price: R${this.PriceInReals(4.43f)}\n" +
             $"Price (dollar): U${this.Price}\n";
    }
  }

  enum EProductType
  {
    Product = 1,
    Service = 2
  }
}