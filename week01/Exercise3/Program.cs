using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        Console.Write("What is your guess? ");
        string input = Console.ReadLine();
        int guess = int.Parse(input);

        int numberOfGuesses = 1;

        while (guess != number)
        {
            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }

            Console.Write("What is your guess? ");
            input = Console.ReadLine();
            guess = int.Parse(input);

            numberOfGuesses += 1;
        }

        Console.WriteLine("You guessed it!");
        Console.WriteLine($"You guessed {numberOfGuesses} time(s).");
    }
}