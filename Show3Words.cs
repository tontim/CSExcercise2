namespace Menu
{
    internal class Show3Words
    {
        public void Display3Words()
        {
            //Försökte på en List<string> här först men insåg jag behöver nog lära mig Linq då 
            //List<string> words = new List<string>();

            Console.Write("Skriv in en mening: ");
            string input = Console.ReadLine();

            //hittade denna funktion för multiple spaces, kändes lite överkurs!
            string[] splitInput = input.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            //Kanske inte den snyggaste lösningen för att kolla efter 3 ord men det får duga!
            while (splitInput.Length < 3)
            {
                Console.WriteLine("Fel fel fel! Skriv minst 3 ord.");
                input = Console.ReadLine();
                splitInput = input.Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

            }

            for (int i = 2;  i < splitInput.Length; i += 3)
            {
                Console.Write(splitInput[i] + ", ");
            }
            Console.WriteLine("\n");
        }



        
    }
}