namespace Console
{
    class Program
    {
        static void Main()
        {
            System.Console.Clear();

            var john = new Names();
            john.Name = "John";
            System.Console.WriteLine(john.Name);
        }
    }

    class Names
    {
        string _name = "";
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}