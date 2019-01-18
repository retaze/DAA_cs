using System;

namespace TryCatchUndFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte trage eine Zahl ein");
            string userInput = Console.ReadLine();
            int ergebnis;

            try
            {
                int userInputAsInt2 = int.Parse(userInput);
                ergebnis = userInputAsInt2 / 0;
                Console.WriteLine(ergebnis);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Durch 0 teilen ist nicht erlaubt");
            }
            catch (Exception)
            {
                Console.WriteLine("Grundlegender Fehler!");
            }
            /*
            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {

                Console.WriteLine("Format war inkorrekt. Du hättest eine Nummer eintragen sollen!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullExeption, der Wert war leer (null).");
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException, der eingegebene Wert war zu lang.");            
            }
            finally
            {
                Console.WriteLine("Ich werde sowieso ausgeführt");
            }
            */
            Console.ReadKey();
        }
    }
}
