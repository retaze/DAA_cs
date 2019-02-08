using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class Box
    {
        //membervariablen
        private string color = "weiß";
        int length;
        int width;

        int volume;

        public Box (int length, int height, int width)
        {
            this.length = length;
            this.Height = height;
            this.width = width;
            
        }

        //auto-implemented property / prop 2x TAB
        public int Height { get; set; }

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0) //throw new Exception("Breite sollte positiv sein!");
                {
                    value = -value;
                }
                width = value;
                
            }
        }

        public int Length
        {
            get => length;
            set => length = value;
        }

        /*
        public int Length
        {
            get
            {
                return length;

            }
            set
            {
                length = value;
            }
        }*/



        public int FrontSurface
        {
            get
            {
                return Height * length;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Länge ist {0} und Höhe ist {1} und Breite ist {2}, somit ist das Volumen {3}", length, Height, width, volume = length*Height
                *width);
        }
    }
}
