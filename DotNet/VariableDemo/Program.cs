using System;

namespace VariableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string myName = "Jani";
            int number = 12345;
            Console.WriteLine(myName);
            Console.WriteLine(number);

            /*
            number = myName;
            Console.WriteLine(number);
            */

            int sum = Sum(100, 200);
            Console.WriteLine(sum);

            string text = "ABC 1234 /()/( υϼІԭՐ۴ݯḓṞ☺Ꜿꝯﷻ ░▌▓";
        }

        private static int Sum(int a, int b) {
            return a+b;
        }
    }
}
