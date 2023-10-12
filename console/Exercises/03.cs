// Exercise 03
namespace StructExercise03
{
    struct Employee
    {
        public string? Name, BirthDay, BirthMonth, BirthYear;

        public readonly override string ToString()
        {
            return
                $"Name: {Name}\n" +
                $"Birth Day: {BirthDay}\n" +
                $"Birth Month: {BirthMonth}\n" +
                $"Birth Month: {BirthYear}\n";
        }
    }

    public class Exercise
    {
        public static void Answer()
        {
            System.Console.WriteLine("Employee #1: ");
            var employee1 = SetEmployeeData();
            System.Console.WriteLine("Employee #2: ");
            var employee2 = SetEmployeeData();
            System.Console.WriteLine("Listing Employee(s) Data... \n");
            System.Console.WriteLine(employee1.ToString());
            System.Console.WriteLine(employee2.ToString());
        }

        static Employee SetEmployeeData()
        {
            Employee employee = new();

            System.Console.WriteLine("Type employee data.");
            System.Console.Write("Name: ");
            employee.Name = Console.ReadLine();
            System.Console.Write("Birth Day: ");
            employee.BirthDay = Console.ReadLine();
            System.Console.Write("Birth Month: ");
            employee.BirthMonth = Console.ReadLine();
            System.Console.Write("Birth Year: ");
            employee.BirthYear = Console.ReadLine();
            System.Console.WriteLine("Press ENTER to finish!");
            Console.ReadLine();

            return employee;
        }
    }
}