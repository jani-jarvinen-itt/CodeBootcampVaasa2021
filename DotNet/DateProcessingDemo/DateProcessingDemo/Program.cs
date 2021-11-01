using System;

namespace DateProcessingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // read the dates from the user
            Console.WriteLine("Enter the first date:");
            string value = Console.ReadLine();
            // int number = int.Parse(value);
            DateTime date1 = DateTime.Parse(value);

            Console.WriteLine("Enter the second date:");
            value = Console.ReadLine();
            DateTime date2 = DateTime.Parse(value);

            // date calculations
            TimeSpan difference = date2 - date1;
            Console.WriteLine("Difference in days: " + difference.TotalDays);
            Console.WriteLine("Difference in hours: " + difference.TotalHours);
        }        
    }
}
