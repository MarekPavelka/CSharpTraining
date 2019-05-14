using System;
using System.Collections.Generic;

namespace SpeedRun2Hours
{
    class Fibonacci
    {
        public static void Solution()
        {
            Console.WriteLine("Kolko cisiel z fibonacciho postupnosti chces vypisat");
            var fibonacciCount = int.Parse(Console.ReadLine());

            foreach (var item in FibonacciList(fibonacciCount))
            {
                Console.WriteLine($"{item}");
            }
        }

        private static List<int> FibonacciList(int count)
        {
            var FibonacciList = new List<int>();
            var a = 0;
            var b = 1;
            var c = 0;

            for (int i = 0; i < count; i++)
            {
                c = b + a;
                FibonacciList.Add(c);
                a = b;
                b = c;
            }
            return FibonacciList;
        }
    }
}
