namespace Menu
{
    public class ShowCinema
    {
        
        public void DisplayCinema()
        {
        
        Console.Write("Kolla biopriset!\n" +
            "Ensam eller sällskap?\n" +
            "[1] - Ensam\n" +
            "[2] - Sällskap\n");

            string selection = Console.ReadLine();
            
            switch (selection)
            {
                case "1":
                    Console.Write("Hur gammal äru? \n");
                    int input = int.Parse(Console.ReadLine());

                    if (input <= 20 && input >= 5)
                    {
                        Console.WriteLine("Ungdomspris: 80kr\n");
                    }
                    else if (input >= 65 && input <= 99)
                    {
                        Console.WriteLine("Pensionärspris: 90kr\n");
                    }
                    else if (input >= 100)
                    {
                        Console.WriteLine("Superpensionärspris: Gratis!\n");

                    }
                    else if (input < 5)
                    {
                        Console.WriteLine("Barn under 5: Gratis!\n");

                    }
                    else
                    {
                        Console.WriteLine("Standardpris: 120kr\n");
                    }
                    break;

                case "2":

                    //här kan jag säkert använda tuple istället för list+int men inte kommit så långt
                    
                    List<int> peopleList = new List<int>();

                    Console.Write("Hur många är ni i sällskapet? ");
                    int peopleCount = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Ange ålder på personerna.");
                    for (int i = 0; i < peopleCount; i++)
                    {
                        Console.Write("Person " + i + ":");
                        int age = int.Parse(Console.ReadLine());
                        peopleList.Add(age);
                    }

                    //inser också att jag hade kunnat skapa en funktion som har en AgeCheck här

                    int ageSum = 0;

                    foreach (var age in peopleList)
                    {
                        if (age <= 20 && age >= 5)
                        {
                            ageSum += 80;
                        }
                        else if (age >= 65 && age <= 99)
                        {
                            ageSum += 90;
                        }
                        else if (age < 5)
                        { 
                            ageSum += 0;
                        }
                        else if (age >= 100)
                        {
                            ageSum += 0;
                        }
                        else
                        {
                            ageSum += 120;
                        }
                    }
                    Console.WriteLine("Det kostar: " + ageSum + " för " + peopleCount + " personer.\n");

                    break;
            }




        }
        
    }
}