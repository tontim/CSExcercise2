namespace Menu
{
    public class ShowCinema
    {
        int input;
        public void DisplayCinema()
        { 

        Console.WriteLine("Bio Priskollen! Ange ålder:");
        input = int.Parse(Console.ReadLine());

            if (input <= 20)
            {
                Console.WriteLine("Ungdomspris: 80kr\n");
            }

            else if (input >= 65)
            {
                Console.WriteLine("Pensionärspris: 90kr\n");

            }
            
            else
            {
                Console.WriteLine("Standardpris: 120kr\n");

            }

        }
        
    }
}