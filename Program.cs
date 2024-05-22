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
                //Printa ut menyn som förklarar valen
                Console.WriteLine("Välkommen till menyn!");
                Console.WriteLine("Välj mellan alternativen:");
                Console.WriteLine("[1] - Bio");
                Console.WriteLine("[2] - Repetera 10");
                Console.WriteLine("[3] - 3 ord");

                string input = Console.ReadLine();

                //Switch för att välja 
                switch (input) 
                {
                    case "1":
                        Console.WriteLine(". . . Visar Bio . . .");
                        _showCinema.DisplayCinema();

                        break;

                    case "2":
                        _showRepeater.DisplayRepeater();
                        break;

                    case "3":
                        _show3Words.Display3Words(); 
                        break;
                 // Bryter om felaktig input
                    default:
                        Console.WriteLine("Wrong input.");
                        break; 

                }
            } while (true);

        }
       
    }
}
