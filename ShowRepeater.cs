namespace Menu
{
    public class ShowRepeater
    {
        public void DisplayRepeater()
        {
            Console.Write("Skriv in något vetja? ");
            string input = Console.ReadLine();
            
        for (int i = 1; i <= 10; i++)
            {
            Console.Write(i + ": " + input + " ");
            }
            Console.WriteLine("\n");

        }
        
    }
}
