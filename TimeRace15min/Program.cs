using System;
using System.Diagnostics;


namespace TimeRace15min
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadaj pocet fibonacciho cisel na vypis: ");
            var wantedNumbersCount = int.Parse(Console.ReadLine());
            var a = 0;
            var b = 1;
            var result = 1;
            var counter = 1;

            while (counter <= wantedNumbersCount)
            {
                counter++;
                Console.WriteLine("{0} ", result);
                result = a + b;
                a = b;
                b = result;
            }
            Console.ReadLine();
        }
    }
}
