using System;

class NumberGuessingGame
{
    static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101); // Generates a random number between 1 and 100

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("I have picked a number between 1 and 100. Try to guess it!");

        int attempts = 0;
        int guess;

        while (true)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            if (guess < 1 || guess > 100)
            {
                Console.WriteLine("Your guess should be between 1 and 100.");
                continue;
            }

            attempts++;

            if (guess == secretNumber)
            {
                Console.WriteLine($"Congratulations! You guessed the number {secretNumber} in {attempts} attempts.");
                break;
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Try a higher number.");
            }
            else
            {
                Console.WriteLine("Try a lower number.");
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}