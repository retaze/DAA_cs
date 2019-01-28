using System;

namespace ErsteKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
    

            Human lars = new Human("Lars", "Gruber","braun",31);           
            lars.IntroduceMyself();

            Human franz = new Human("Franz", "Heide","schwarz",59);            
            franz.IntroduceMyself();

            Human amalia = new Human("Amalia", "Panjuta", "blau", 1);
            amalia.IntroduceMyself();

            Human Martina = new Human("Martina", "Müller", "grün");
            Martina.IntroduceMyself();

            Human unbekannterMensch = new Human();
            unbekannterMensch.IntroduceMyself();

            Console.ReadKey();
                    



        }
    }
}
