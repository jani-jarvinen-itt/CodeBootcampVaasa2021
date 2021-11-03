using System;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // traditional programming
            int[] numbers = { 3, 6, 10, 4, 7, 11, 5, 9, 12 };
            Array.Sort(numbers);
            foreach (int number in numbers)
            {
                if (number > 5)
                {
                    // Console.WriteLine(number);
                }
            }

            // LINQ demo
            int[] numbers2 = { 3, 6, 10, 4, 7, 11, 5, 9, 12 };
            var largerThanFive = (from n in numbers2
                                  where n > 5
                                  orderby n
                                  select n);
            foreach (int number in largerThanFive)
            {
                Console.WriteLine(number);
            }
        }
    }
}
