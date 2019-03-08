using System;

namespace _02_03_ZlteKarticky
{
    class Factorial
    {
        public static void Solution()
        {
            Console.WriteLine("Zadaj cislo z ktoreho mam vyratat faktorial: ");
            var number = int.Parse(Console.ReadLine());
            var result = 1;

            for (int i = number; i > 0; i--)
            {
                result = result * i;
            }
            Console.WriteLine("{0}! je {1}", number, result);
            Console.ReadKey();
        }
    }
}