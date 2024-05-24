namespace Menu
{
    public class ShowRepeater
    {
        public void DisplayRepeater()
        {
            Console.Write("Skriv in något vetja? ");
            string input = Console.ReadLine();

            while (input != null)
            {
                Console.Write("Nej, skriv något sa jag.");
                input = Console.ReadLine();
            }
            
        for (int i = 1; i <= 10; i++)
            {
            Console.Write(i + ": " + input + " ");
            }
            Console.WriteLine("\n");

        }
        
    }
}
