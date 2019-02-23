using System;

namespace _23_2_SummationFrom1toNum
{
    class Program
    {
        static void Main()
        {
            var x = 8;
            int sum = 0;
            for (var start = 1; start <= x; start++)
            {
                Console.Write("{0}", start);
                sum = sum + start;
            }
            Console.WriteLine();
            Console.WriteLine("Sucet tychto cisiel je {0}", sum);
            Console.ReadKey();
        }
    }
}
