using System;

class NumberGuessingGame
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("I have picked a number between 1 and 100. Try to guess it!");

        bool playAgain = true;
        int totalAttempts = 0;
        int rounds = 0;

        while (playAgain)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 101); // Generates a random number between 1 and 100
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
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Congratulations! You guessed the number {secretNumber} in {attempts} attempts.");
                    Console.ResetColor();

                    totalAttempts += attempts;
                    rounds++;
                    break;
                }
                else if (guess < secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try a higher number.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try a lower number.");
                    Console.ResetColor();
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            string playAgainInput = Console.ReadLine().ToLower();

            if (playAgainInput != "yes")
            {
                playAgain = false;
            }
        }

        double averageAttempts = (double)totalAttempts / rounds;
        Console.WriteLine($"Thanks for playing! Your average attempts per round: {averageAttempts:F1}");
    }
