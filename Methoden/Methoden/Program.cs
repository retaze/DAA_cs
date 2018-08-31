using System;

namespace Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomething();
            WriteSomething();
            string myArgument = "Hallo, ich bin super Text";
            WriteSomethingSpecific(myArgument);

        }

        public static void WriteSomething()
        {
            Console.WriteLine("Ich bin eine Methode");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

    }
}
