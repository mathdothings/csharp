// Exercise 02
namespace StructExercise02;

struct Sum
{
    public static int x = 20;
    public static int y = 20;
}

class Exercise
{
    public static void Answer()
    {
        System.Console.WriteLine("Exercise 02");
        System.Console.WriteLine("The sum is: ");
        System.Console.WriteLine($"{Sum.x} + {Sum.y} = "
            + $"{Sum.x + Sum.y}");
    }
}