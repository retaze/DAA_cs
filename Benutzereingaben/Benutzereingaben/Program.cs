using System;

namespace Benutzereingaben
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate());
            Console.ReadKey();
            
        }

        public static int Calculate()
        {
            Console.WriteLine("Bitte trage die erste Zahl ein.");
            string num1Input = Console.ReadLine();
            Console.WriteLine("Bitte trage die zweite Zahl ein.");
            string num2Input = Console.ReadLine();

            int num1 = int.Parse(num1Input);
            int num2 = int.Parse(num2Input);

            int result = num1 + num2;
            return result;

        }
    }

}
