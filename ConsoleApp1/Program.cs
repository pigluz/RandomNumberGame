using System.Net.Http.Headers;

Console.WriteLine("Guess the number\n");
Thread.Sleep(1000);

while (true)
{
    try
    {
        //Generates random number
        Random rand = new Random();
        int randomNumber = rand.Next(1, 100);
    
        //User inputs a number
        Console.WriteLine("Enter your number from 1 to 100:");
        int userNumber = Convert.ToInt32(Console.ReadLine());

        while (true) 
        {
            //If user enters the number that is higher than 100:
            if (userNumber > 100)
            {
                Console.WriteLine("\nYou entered a value that is higher than 100. Please enter a new value.");
                break;
            } 
        
            //If user enters the number that is lower than 0:
            else if (userNumber < 0)
            {
                Console.WriteLine("\nYou entered a value that is lower than 0. Please enter a new value.");
                break;
            }
        
            //If user enters the number correctly, the game continues:
            else
            {
                //If the user number is higher than the generated number:
                if (userNumber > randomNumber)
                {
                    Console.WriteLine("You entered a number that is higher than the generated number.");
                    GeneratedNumberInfo(randomNumber);

                }
                //If it's lower:
                else
                {
                    Console.WriteLine("You entered a number that is lower than the generated number.");
                    GeneratedNumberInfo(randomNumber);
                }
    
                Console.Write("\nDo you want to play again? ");
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "no")
                {
                    return;
                }
                else
                {
                    break;
                }
            }
        }
    }
    
        //If user enters not an int:
    catch (System.FormatException e)
    {
        throw new ("You entered not an int.");
    }
}


void GeneratedNumberInfo(int randomNumber)
{
    Console.WriteLine($"The generated number was {randomNumber}.");
}