using System;

namespace DateProcessingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // read the dates from the user
            DateTime date1 = ReadDateFromUser("Enter the first date:");
            DateTime date2 = ReadDateFromUser("Enter the second date:");

            // display the values entered
            Console.WriteLine("First date: " + date1);
            Console.WriteLine("Second date: " + date2);

            // date calculations
            TimeSpan difference = date2 - date1;
            Console.WriteLine("Difference in days: " + difference.Days);
            Console.WriteLine("Difference in hours: " + difference.Hours);
            Console.WriteLine("Difference in total days: " + difference.TotalDays);
            Console.WriteLine("Difference in total hours: " + difference.TotalHours);
        }

        private static DateTime ReadDateFromUser(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string value = Console.ReadLine();
                try
                {
                    DateTime date = DateTime.Parse(value);
                    return date;
                }
                catch
                {
                    Console.WriteLine("The date entered was invalid. Please try again.");
                }
            }
        }
    }
}
