using System;

namespace _01_03_ZlteKarticky
{
    internal class Fibonacci
    {
        public static void Solution()
        {
            Console.WriteLine("Zadaj fibonacciho cislo:");
            var userInput = int.Parse(Console.ReadLine());
            var a = 0;
            var b = 1;
            var result = 1;

            for (int counter = 1; counter <= userInput; counter++)
            {
                Console.WriteLine("{0}", result);
                result = b + a;
                a = b;
                b = result;
            }
        }

    }
}