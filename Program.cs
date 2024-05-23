using System;
using System.Collections.Generic;
namespace Menu
{
     internal class Program
    {
        private static ShowCinema _showCinema = new ShowCinema();
        private static ShowRepeater _showRepeater = new ShowRepeater();
        private static Show3Words _show3Words= new Show3Words();
        static void Main(string[] args)
        {

            do
            {
                
                Console.Write("Välkommen till menyn!\n" +
                    "Välj Mellan alternativen:\n" +
                    "[1] - Biopriser\n" +
                    "[2] - Repetera 10\n" +
                    "[3] - 3 ord\n" +
                    "[0] - Avsluta\n" +
                    "Val: ");

                string input = Console.ReadLine();

                 
                switch (input) 
                {
                    case "1":
                        Console.WriteLine("\n_____ Visar Bio\n");
                        _showCinema.DisplayCinema();

                        break;

                    case "2":
                        Console.WriteLine("\n_____ Visar Repeterare\n");

                        _showRepeater.DisplayRepeater();
                        break;

                    case "3":
                        Console.WriteLine("\n_____ Visar Tredje Ordet\n");

                        _show3Words.Display3Words(); 
                        break;

                    case "0":
                        Environment.Exit(0);
                        break;

                 //Bryter vid felaktig input
                    default:
                        Console.WriteLine("Wrong input.");
                        break; 

                }
            } while (true);

        }
       
    }
}
