namespace Console
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var player = new Player();
            Console.Clear();
            Console.WriteLine($"Name: '{player.Name}'");
            Console.WriteLine($"Attack: '{player.Attack}'");
            Console.WriteLine($"Ping: '{player.Ping}'");
            Console.WriteLine($"Alive: '{player.Alive}'");
        }
    }

    public class Unit
    {
        public string? Type { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int HP { get; set; }
        public int Speed { get; set; }
        public bool Alive { get; set; }
    }

    public class Player : Unit
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public float Ping { get; set; }
    }
}