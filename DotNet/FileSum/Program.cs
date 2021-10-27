using System;
using System.IO;

namespace FileSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "C:\\Bootcamp\\Vaasa\\Numbers.txt";
            string[] lines = File.ReadAllLines(filename);

            int sum = 0;
            foreach (string line in lines)
            {
                int value = int.Parse(line);
                sum += value;   // sum = sum + value;
            }

            Console.WriteLine("Calculated sum is: " + sum);
        }
    }
}
