using System;
using System.Collections.Generic;
using System.Text;

namespace ErsteKlasse
{
    class Human
    {
        //Membervariable
        string firstname;
        string lastname;
        string eyeColor;
        int age;

        //Default Kontruktor
        public Human()
        {
            Console.WriteLine("Default Konstruktor aufgerufen");
            age = 0;
            eyeColor = "braun";
            firstname = "Unbekannt";
            lastname = "Unbekannt";        

        }



        //Parameterisierter Konstruktor
        public Human(string firstname, string lastname, string eyeColor, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public Human (string firstname, string lastname, string eyeColor)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.eyeColor = eyeColor;
        }
        public Human(string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;  
        }
        public Human(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }


        public void IntroduceMyself()
        {

            if (age != 0 && lastname != null && eyeColor != null && firstname != null)
            {
                Console.WriteLine("Hi, Ich bin " + firstname + " " + lastname);
                Console.WriteLine("Meine Augenfarbe ist " + eyeColor + " und ich bin " + age+" Jahr alt");
            } else if (lastname != null && eyeColor != null && firstname != null)
            {
                Console.WriteLine("Hi, Ich bin " + firstname + " " + lastname);
                Console.WriteLine("Meine Augenfarbe ist " + eyeColor);
            } else if (lastname != null && age != 0 && firstname != null)
            {
                Console.WriteLine("Hi, Ich bin " + firstname + " " + lastname +" und mein Alter ist "+age);
            }
            else if (lastname != null && firstname != null)
            {
                Console.WriteLine("Hi, Ich bin " + firstname + " " + lastname);
            }

        }



    }
}
