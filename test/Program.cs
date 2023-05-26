using MySqlConnector;
namespace MyApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      var keyboard = new Product(1, "Keyboard Log", 100.00f, EProductType.Product);
      // Console.WriteLine(keyboard.ShowInfo());

      var course = new Product(2, "C# Fundamentals", 50.00f, EProductType.Service);
      // Console.WriteLine(course.ShowInfo());

      string connectionString = "Server=localhost;User ID=root;Password=PassWord123#@!;Database=dates";
      using var connection = new MySqlConnection(connectionString);
      connection.Open();
      var command = new MySqlCommand("INSERT INTO comments(content) VALUES('Testing new content')", connection);
      command.ExecuteNonQuery();
      connection.Close();
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