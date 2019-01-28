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

        public Human(string firstname, string lastname, string eyeColor, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.eyeColor = eyeColor;
            this.age = age;

        }




        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, Ich bin "+firstname+" "+lastname);
            Console.WriteLine("Meine Augenfarbe ist "+eyeColor+" und mein Alter "+age);

        }



    }
}
