// Exercise 04
namespace StructExercise04;

struct StructCoordinates
{
    public int x, y;
    public readonly override string ToString() => $"({x}, {y})";
}

class ClassCoordinates
{
    public int x, y;
    public override string ToString() => $"({x}, {y})";
}

class Exercise
{
    public static void Answer()
    {
        var structCoordinates1 = new StructCoordinates
        {
            x = 750,
            y = 950
        };

        var structCoordinates2 = structCoordinates1;
        structCoordinates2.x = 1000;
        structCoordinates2.y = 5000;

        var classCoordinates1 = new ClassCoordinates
        {
            x = 7500,
            y = 9500
        };

        var classCoordinates2 = classCoordinates1;
        classCoordinates2.x = 3000;
        classCoordinates2.y = 1000;

        System.Console.WriteLine($"Class 1: {classCoordinates1}");
        System.Console.WriteLine($"Class 2: {classCoordinates2}");
        System.Console.WriteLine($"Struct 1: {structCoordinates1}");
        System.Console.WriteLine($"Struct 2: {structCoordinates2}");
    }
}