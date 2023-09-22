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



            for (int i = 0; i < 5; i++) // for loop som loopas max 5 gånger
            {
                int answer = Int32.Parse(Console.ReadLine()); //Måste vara inne i lopen annars går den bara en gång utanför loopen. 

                if (answer == number) //om answer ( user input ) är lika med random numret så skrivs nedan ut och programet är färdigt
                {
                    rightGuess = true;
                    Console.WriteLine("Woho! Du gjorde det!");
                    break;
                }
                else
                {
                    if (answer < number) //om answer ( user input ) är mindre än random numret så skrivs  det ut för lågt annars för högt.
                        Console.WriteLine("Tyvärr du gissade för lågt!");
                    else
                        Console.WriteLine("Du gissade för högt!");
                }

            }

            if (!rightGuess)    //utropet vänder boolen till true efter fem försök
                Console.WriteLine("Tyvärr du lyckades inte på fem försök!");

            Console.ReadLine();
        }
        static void Welcome() // en void som inte ska retunera något.Är static och inte public eftersom jag inte behöver komma åt andra klasser 
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök");
        }
    }
}