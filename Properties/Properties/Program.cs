﻿using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(5,3,4);
            Console.WriteLine("Die Front-Fläche ist {0}", box.FrontSurface);
            

            box.DisplayInfo();



            Console.ReadKey();
        }
    }
}
