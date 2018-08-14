using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{

    class Class1
    {
        private string name;

        public void SetName()
        {
            name = "Lars ist Chef";
        }

        public void SchreibeName()
        {
            Console.WriteLine(name);
            Console.WriteLine();
        }

        public string GibName()
        {
            return (name);
        }

    }

}

