using System;

namespace Benutzereingabe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Das Ergebnis der Addition beider Zahlen ist: "+ Add());

            

        }
        public static int Add()
        {
            Console.WriteLine("Bitte zwei Zahlen eingeben: ");
            string zahl1 = Console.ReadLine();
            string zahl2 = Console.ReadLine();
            int zahl3 = int.Parse(zahl1);
            int zahl4 = int.Parse(zahl2);
            return zahl3 + zahl4;
        }
    }
}
