using System;

namespace _02_03_ZlteKarticky
{
    class Fibonacci
    {
        public static void Solution()
        {
            Console.WriteLine("Zadaj kolko cisiel z fibonacciho postupnosti chces vypisat:");
            var fNumber = int.Parse(Console.ReadLine());
            var a = 0;
            var b = 1;
            var result = 1;
            for (int i = 1; i <= fNumber; i++)
            {
                Console.WriteLine("{0}", result);
                result = b + a;
                a = b;
                b = result;
            }

            Console.ReadKey();
        }
    }
}