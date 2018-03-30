using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            DateTime dt = DateTime.Now;
            Console.WriteLine($"Hello, {name}!  The current time is {dt}");
            Console.Write("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
