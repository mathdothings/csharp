namespace StructExercise10;

struct Square
{
    public int width;
    public int height;

    public int area() => width * height;
    public int perimeter() => width * 2 + height * 2;
}

class Exercise
{
    public static void Answer()
    {
        var square = new Square();
        System.Console.WriteLine("Input square dimentions: ");
        System.Console.Write("Width: ");
        square.width = int.Parse(Console.ReadLine() ??
            throw new Exception("Invalid value!"));
        System.Console.Write("Height: ");
        square.height = int.Parse(Console.ReadLine()
            ?? throw new Exception("Invalid value!"));
        System.Console.WriteLine($"Area: {square.area()}");
        System.Console.WriteLine($"Perimeter: {square.perimeter()}");
    }
}