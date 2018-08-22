using System;

namespace ImpliziteUndExpliziteKonvertierung
{
    class Program
    {
        static void Main(string[] args)
        {

            //Implizite Konvertierung
            int num = 1234245;
            long bigNum = num;

            float myFloat = 13.37f;
            double myDouble = myFloat;

            //Explizite Konvertierung
            int myInt;
            double myNewDouble = 13.37;
            myInt = (int)myNewDouble;

            string myString = myNewDouble.ToString();
            string myString2 = myString + "12";



            Console.WriteLine(myString2);
            Console.ReadKey();
        }
    }
}
