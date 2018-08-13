using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    internal class Hauptprogramm
    {
        static void Main(string[] args)
        {
            Class1 person = new Class1();
            string einName;

            person.SetName();
            einName = person.GibName();
            Console.WriteLine(einName);
            //person.SchreibeName();

        }
    }
}
   
