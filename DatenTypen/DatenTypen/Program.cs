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

            double d1 = 333.5;
            double d2 = 1.337;
            double ergebnis = d1 / d2;

            float f1 = 1.337f;

            string meinName = "Lars";
            string nachricht = "Mein Name ist " + meinName;
            int laengeDesStrings = nachricht.Length;
            string allesGrossgeschrieben = nachricht.ToUpper();
            string allesKleinGeschrieben = nachricht.ToLower();

            Console.WriteLine(allesKleinGeschrieben);
            Console.WriteLine(allesGrossgeschrieben);
            Console.WriteLine(nachricht + " ist {0} Zeichen lang", laengeDesStrings);
            Console.ReadKey();
        }
    }
}
