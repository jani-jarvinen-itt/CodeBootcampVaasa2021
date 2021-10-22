using System;

namespace BasicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int number = 1000;
            if (number < 100) {
                System.Console.WriteLine("The number is less than 100!");
            }
            if (number >= 100) {
                System.Console.WriteLine("The number is exactly or larger than 100!");
            } */

            /* Console.WriteLine("Please enter a number:");
            string number = Console.ReadLine();
            int value = int.Parse(number);
            value = value + 10;
            Console.WriteLine(value); */

            /* int[] number = { 2, 4, 6, 8, 9 }; // length = 5
            for (int i = 0; i < number.Length; i++)
            {
                int valueInArray = number[i];
                Console.WriteLine(valueInArray);
            }

            foreach (int value in number)
            {
                Console.WriteLine(value);
            } */


            double result = 123 / 4.7;
            Console.WriteLine(result);
            Console.WriteLine("{0} - {1:N5}", 987, result);


            /* for (int counter = 0; counter < 10; counter++)
            {
                
            }

            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
            Console.WriteLine(5);
            Console.WriteLine(6); */
        }
    }
}
