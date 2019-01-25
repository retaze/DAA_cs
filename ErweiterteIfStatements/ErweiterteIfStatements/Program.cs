using System;

namespace ErweiterteIfStatements
{
    class Program
    {
        /* Bedingung ? erster Ausdruck : zweiter Ausdruck
         * Bedingung muss entweder wahr oder falsch sein
         * Beispiel: a ? b : c
         */

        static void Main(string[] args)
        {
            int temperatur = -5;
            string stateOfMatter;

            if (temperatur < 0)
            {
                stateOfMatter = "fest";
            }
            else
            {
                stateOfMatter = "flüssig";
            }

            Console.WriteLine("Aggregatszustand ist "+stateOfMatter);

            Console.ReadKey();
        }
    }
}
