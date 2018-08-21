using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hallo Welt!");
            Console.WriteLine("Hallo Lars");

            Console.ReadKey();
        }
    }
}
