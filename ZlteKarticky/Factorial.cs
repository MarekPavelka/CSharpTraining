using System;

namespace ZlteKarticky
{
    class Factorial
    {
        public static void Run()
        {
            Console.WriteLine("Zadaj cislo pre vypocet faktorialu: ");
            var number = int.Parse(Console.ReadLine());

            var result = 1;
            // 5, 4, 3, 2
            for (int i = number; i > 1; i--)
            {
                result = result * i;
            }

            Console.WriteLine("Vysledok faktorialu z cisla {0} je {1}", number, result);
        }
    }
}
