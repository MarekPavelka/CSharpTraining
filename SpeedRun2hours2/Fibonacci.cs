using System;

namespace SpeedRun2hours2
{
    class Fibonacci
    {
        public static void Solution()
        {
            Console.WriteLine("Napis kolko cisiel z fibonaciho postupnosti chces vypisat");
            var userInput = int.Parse(Console.ReadLine());
            var a = 0;
            var b = 1;
            var c = 1;

            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine(c);
                c = b + a;
                a = b;
                b = c;
            }
        }
    }
}
