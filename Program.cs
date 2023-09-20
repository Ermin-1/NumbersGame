namespace NumbersGame
{
    internal class Program
    {
        static void Main()

        {
            Random random = new Random();
            int number = random.Next(1, 20);
            bool rightGuess = false;

            Welcome();



            for (int i = 0; i < 5; i++)
            {
                int answer = Int32.Parse(Console.ReadLine()); //Måste vara inne i lopen annars går den bara en gång utanför loopen. 

                if (answer == number)
                {
                    rightGuess = true;
                    Console.WriteLine("Woho! Du gjorde det!");
                    break;
                }
                else
                {
                    if (answer < number)
                        Console.WriteLine("Tyvärr du gissade för lågt!");
                    else
                        Console.WriteLine("Du gissade för högt!");
                }

            }

            if (!rightGuess)    //utropet vänder boolen till true
                Console.WriteLine("Tyvärr du lyckades inte på fem försök!");

            Console.ReadLine();
        }
        static void Welcome() // en void som inte ska retunera något.Är static och inte public eftersom jag inte behöver komma åt andra klasser 
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök");
        }
    }
}