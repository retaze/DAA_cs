using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            CPerson person = new CPerson();
            person.SetName();
            person.SchreibeName();

        }
    }

    class CPerson
    {
        private string name;

        public void SetName()
        {
            name = "Kaiser";
        }

        public void SchreibeName()
        {
            Console.WriteLine(name);
            Console.WriteLine();
        }
    }

}

