using System;

namespace _01_03_ZlteKarticky
{
    class Factorial
    {
        public static void Solution()
        {
            Console.WriteLine("Zadaj cislo pre vypocet faktorialu:");
            var userInput = int.Parse(Console.ReadLine());
            Console.Write("{0}! je ", userInput);
            Solve(userInput);
        }

        public static void Solve(int userInput)
        {
            for (int i = userInput; i > 0; i--)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}