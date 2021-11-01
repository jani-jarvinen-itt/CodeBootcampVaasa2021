using System;
using System.Globalization;

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
            CultureInfo enUS = new("en-US");
            CultureInfo fr = new("fr");
            Console.WriteLine("First date (default format): " + date1);
            Console.WriteLine("Second date (default format): " + date2);
            Console.WriteLine("First date (en-US): " + date1.ToString(enUS));
            Console.WriteLine("First date (fr): " + date1.ToString(fr));
            Console.WriteLine("First date (custom): " + date1.ToString("yyyy$MM"));
            Console.WriteLine();

            int number = 1234;
            string value = number.ToString();

            // DateTime parsedDate = DateTime.Parse("11/6/2021", enUS);

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
