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
            Console.WriteLine(correctAnswer);

            for (int tryNumber = 0; tryNumber < 3; tryNumber++)
            {
                
            }
        }
    }
}
