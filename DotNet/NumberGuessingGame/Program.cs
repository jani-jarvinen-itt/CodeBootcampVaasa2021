using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Random random = new();
            int correctAnswer = random.Next(1, 21);
            // Console.WriteLine(correctAnswer);

            for (int tryNumber = 0; tryNumber < 3; tryNumber++)
            {
                Console.WriteLine("Enter your guess from 1 to 20:");
                int guess = int.Parse(Console.ReadLine());

                if (guess < correctAnswer)
                {
                    Console.WriteLine("The correct number is larger.");
                }
                else if (guess > correctAnswer)
                {
                    Console.WriteLine("The correct number is smaller.");
                }
                else
                {
                    Console.WriteLine("Correct! You win!");
                    break;
                }
            }

            Console.WriteLine("Game has finished, thanks for playing!");
        }
    }
}
