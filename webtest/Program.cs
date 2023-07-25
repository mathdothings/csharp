using App2;

namespace App
{
  public class Program
  {
    static void Main(string[] args)
    {
      var builder = WebApplication.CreateBuilder(args);
      var app = builder.Build();

      var hello = new Program2();

      app.MapGet("/", () => "Hello World!");
      app.MapGet("/home", () => hello.Show());

      var response = app.MapPost("/home2", () => hello.Show());
      app.Run();
    }
  }
}

namespace App2
{
  class Program2
  {
    public string Show() { return "Hello!"; }
  }
}