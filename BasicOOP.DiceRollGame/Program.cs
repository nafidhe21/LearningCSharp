Random rnd = new Random();
int randomInt = rnd.Next(1, 7);

Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");

int chances = 3;

while (chances > 0)
{
    int userGuess;
    Console.WriteLine("Enter number:");
    bool parseUserGuessToIntSuccessfull = int.TryParse(Console.ReadLine()!, out userGuess);

    if (parseUserGuessToIntSuccessfull)
    {
        if (userGuess == randomInt)
        {
            Console.WriteLine("You Win");
            break;
        }
        else
        {
            Console.WriteLine("Wrong number");
            chances--;
            if (chances == 0)
            {
                Console.WriteLine("You lose.");
            }
        }
    }
    else
    {
        Console.WriteLine("Incorrect Input.");
    }

}