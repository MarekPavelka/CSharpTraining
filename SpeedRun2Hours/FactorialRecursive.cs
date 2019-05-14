using System;

namespace SpeedRun2Hours
{
    class FactorialRecursive
    {
        public static void Solution()
        {
            Console.WriteLine("Zadaj cislo na vypocet faktorialu:");
            var input = int.Parse(Console.ReadLine());
            var result = FactorialSolution(input);
            Console.WriteLine($"Result is {result}");
        }

        private static int FactorialSolution(int input)
        {
            if (input == 1)
            {
                return 1;
            }
            return input * FactorialSolution(input - 1);
        }
    }
}
