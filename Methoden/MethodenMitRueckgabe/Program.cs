using System;

namespace MethodenMitRueckgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine(Add(Add(1,2), Add(3,4)));
            Console.WriteLine(Add(15, 23));
            Console.WriteLine(Multiply(32,55));*/

            string freund1 = "Sebastian";
            string freund2 = "Till";
            string freund3 = "Björn";

            GreetFriend(freund1, freund2, freund3);
           
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static void GreetFriend(string friend, string friend2, string friend3)
        {
            Console.WriteLine("Hi {0}, {1} und {2}, meine Freunde!", friend, friend2, friend3);
        }
      

    }
}
