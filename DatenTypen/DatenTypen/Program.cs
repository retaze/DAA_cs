using System;

namespace DatenTypen
{
    class Program
    {
        static void Main(string[] args)
        {
            int wert1 = 25;

            int wert2;
            wert2 = 15;

            int summe = wert1 + wert2;

            int wert3, wert4, wert5;

            double d1 = 3.5;
            double d2 = 1.337;
            double ergebnis = d1 / d2;

            Console.WriteLine("Ergebniss ist "+ergebnis);
            Console.ReadKey();
        }
    }
}
