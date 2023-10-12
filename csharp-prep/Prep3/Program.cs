using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;
        
        do 
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            int guess;
            int tracker = 0;

            do
            {
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);

                tracker++;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                }
            } while (guess != magicNumber);

            Console.WriteLine($"It took you {tracker} times to guess the number.");
            
            Console.Write("Would you like to play again? ");
            playAgain = Console.ReadLine();

        } while (playAgain != "no");

    }
}   

