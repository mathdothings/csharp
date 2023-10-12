// Exercise 01
namespace StructExercise01
{
    struct Sum
    {
        public int x, y;
    }

    public class Exercise
    {
        public static void Answer()
        {
            Sum sum = new()
            {
                x = 10,
                y = 30
            };

            System.Console.WriteLine("Exercise 01");
            System.Console.WriteLine("The sum is: ");
            System.Console.WriteLine($"{sum.x} + {sum.y} = "
                + $"{sum.x + sum.y}");
        }
    }
}