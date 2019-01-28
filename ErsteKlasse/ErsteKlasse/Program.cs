using System;

namespace ErsteKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
    

            Human lars = new Human("Lars", "Gruber","Braun",31);           
            lars.IntroduceMyself();

            Human franz = new Human("Franz", "Heide","Schwarz",59);            
            franz.IntroduceMyself();
        
     

            Console.ReadKey();
                    



        }
    }
}
