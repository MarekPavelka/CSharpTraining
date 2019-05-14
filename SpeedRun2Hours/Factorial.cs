using System;

namespace SpeedRun2Hours
{
    class Factorial
    {
        public static void Solution()
        {
            Console.WriteLine("Zadaj cislo z ktoreho chces vypocitat faktorial:");
            var factorialNumber = int.Parse(Console.ReadLine());
            var result = factorialNumber;
            for (int i = factorialNumber - 1; i > 1; i--)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }
    }
}
