using System;

namespace SpeedRun2hours2
{
    class FactorialRecursive
    {
        public static void Solution()
        {
            Console.WriteLine("Zadaj cislo na vypocet faktorialu: ");
            var userInput = int.Parse(Console.ReadLine());

            Console.WriteLine($"Vysledok {userInput}! je {FaktorialRecursive(userInput)}");
        }

        public static int FaktorialRecursive(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            return number * FaktorialRecursive(number - 1);
        }
    }
}
