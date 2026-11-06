using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guessCount = 0;
            int guess = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Please enter a whole number.");
                    continue;
                }

                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You made {guessCount} guesses.");
                }
            }

            Console.Write("Would you like to play again? ");
            playAgain = Console.ReadLine().Trim().ToLower();
        }
    }
}