using System;

namespace Operatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //inäre Operatoren
            num3 = -num1;
            Console.WriteLine("num3 ist"+num3);

            bool isSunny = true;
            Console.WriteLine("Ist es sonnig? "+ !isSunny);

            //inkrementoperatoren
            int num = 0;
            num++;
            Console.WriteLine("num ist "+num++);

            //pre increment
            Console.WriteLine("num ist " + ++num);

            //decrement Operator
            num--;
            Console.WriteLine("num ist " + num);
            Console.WriteLine("num ist " + num--);

            //pre decrement
            Console.WriteLine("num ist " + --num);

            int result;

            result = num1 + num2;
            Console.WriteLine("Ergebnis von num1: {0} + num2: {1} ist {2}", num1, num2, result);
         

             


            Console.ReadKey();
        }
    }
}
